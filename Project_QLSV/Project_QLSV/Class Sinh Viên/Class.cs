using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV.Class_Sinh_Viên
{
    public partial class Class : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        public Class()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            LoadDS();
            Load_cbnganh();
            Load_cbKhoa();
            Load_cblop();
            txtmalop.Text = string.Empty;
        }
        private void Load_cblop()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select malop, tenlop from lop", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["tenlop"] = "---Chọn lớp học---";
            tb.Rows.InsertAt(r, 0);

            cblop.DataSource = tb;
            cblop.DisplayMember = "tenlop";
            cblop.ValueMember = "tenlop";
        }
        private void Load_cbnganh()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from nganh", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["tenNganh"] = "---Chọn Ngành---";
            tb.Rows.InsertAt(r, 0);

            cbnganh.DataSource = tb;
            cbnganh.DisplayMember = "tenNganh";
            cbnganh.ValueMember = "tenNganh";
        }
        private void Load_cbKhoa()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from khoahoc", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["khoa"] = "---Chọn Ngành---";
            tb.Rows.InsertAt(r, 0);

            cbkhoa.DataSource = tb;
            cbkhoa.DisplayMember = "khoa";
            cbkhoa.ValueMember = "khoa";
        }
        public void LoadDS()
        {
            string a = "";
            string sql = "AllLop";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@keys",
                value = a
            });
           
            dgvlop.DataSource = new Database().SelectData(sql, list);

            // hiển thị số thành viên trong lớp -------------------------
            List<object> columnData = new List<object>();
            foreach (DataGridViewRow row in dgvlop.Rows) // duyệt số dòng
            {
                if (row.Cells[dgvlop.Columns["tenlop"].Index].Value != null) // KT xem dòng của cột tenlop đến null chưa
                {
                    var r = row.Cells[dgvlop.Columns["tenlop"].Index].Value; // gán r = tenlop
                    var r1 = new Database().Select("counts '" + r + "'"); // sql lấy ra số bạn thuộc lớp
                    object cellValue = r1["number"].ToString(); // gán bằng 1 obj
                    columnData.Add(cellValue); // add vào list
                }

            }
            int rowCount = columnData.Count;
            // Đảm bảo số lượng dòng trong DataGridView đủ để chứa dữ liệu
            if (rowCount > dgvlop.Rows.Count)
            {
                dgvlop.Rows.Add(rowCount - dgvlop.Rows.Count);
            }
            // in ra thông in của từng dòng
            for (int i = 0; i < rowCount; i++)
            {
                dgvlop.Rows[i].Cells["SL"].Value = columnData[i];
            }
            
        }
        
        private void dgvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var lop = dgvlop.Rows[e.RowIndex].Cells["tenlop"].Value.ToString();
                
                // truyền msv vào from sinh viên
                new SVinClass(lop).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                LoadDS();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn Thêm không ??",
                "Thông báo!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string lop   = txtlop.Text;
                string malop = txtmalop.Text;
                string nganh = cbnganh.SelectedValue.ToString();
                string limit = txtlimit.Text;
                string sql = "AddKhoaLop";
                List<CustomParameter> list = new List<CustomParameter>();
                list.Add(new CustomParameter() { key = "@tenlop", value = lop });
                list.Add(new CustomParameter() { key = "@malop", value = malop });
                list.Add(new CustomParameter() { key = "@maxsize", value = limit });
                list.Add(new CustomParameter() { key = "@tenNganh", value = nganh });

                var rs = new Database().Execute(sql, list); // truyền 2 tham số vào SQL

                if (rs != 1) // thực thi thành công
                {
                    MessageBox.Show("Thêm mới thành công");
                    cbkhoa.SelectedIndex = 0;
                    cbnganh.SelectedIndex = 0;
                    txtmalop.Text = string.Empty;
                    txtlimit.Text = string.Empty;
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Thêm Lớp Thất Bại");
                }
            }
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmalop.Text = cbkhoa.SelectedValue.ToString();
        }

        private void txtmalop_TextChanged(object sender, EventArgs e)
        {
            txtlop.Text = txtmalop.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            string lop = cblop.SelectedValue.ToString();
            List<CustomParameter> list = new List<CustomParameter>();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn Xóa ??",
                "Thông báo!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(lop))
                {
                    sql = "Deletelop";
                    list.Add(new CustomParameter() { key = "@lop", value = lop });
                }
                var rs = new Database().Delete(sql,list);
                MessageBox.Show("Xóa Thành Công");
                LoadDS();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
