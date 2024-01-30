using Project_QLSV.Kỷ_Luật;
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

namespace Project_QLSV
{
    public partial class FrmKyLuat : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        public FrmKyLuat()
        {
            InitializeComponent();

        }
        string keys = "";
       
        private void FrmKyLuat_Load(object sender, EventArgs e)
        { 
            loadDSKL();
            Load_cblop();
            
        }

        public void loadDSKL()
        {
            if(txtSearch.Text != null)
            {
                keys = txtSearch.Text;
            }
            List<CustomParameter> listPara = new List<CustomParameter>();
            listPara.Add(new CustomParameter()
            {
                key = "@keys",
                value = keys
            });
            // load all sinh vien khi from dc load
            dgvKyluat.DataSource = new Database().SelectData("SelectAllKyluat", listPara);
        
            dgvKyluat.Columns["tenlop"].HeaderText = "Tên Lớp";
            dgvKyluat.Columns["maSV"].HeaderText = "Mã Sinh Viên";
            dgvKyluat.Columns["hoten"].HeaderText = "Họ và Tên";
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

            cbLop.DataSource = tb;
            cbLop.DisplayMember = "tenlop";
            cbLop.ValueMember = "tenlop";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbLop.SelectedIndex = 0;
            loadDSKL();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ADDKyLuat(null).ShowDialog(); // nếu thêm mới thì msv = null
            // ngay add xong TT kết thúc from thì load lại
            loadDSKL(); // khi thêm mới xong thì load lại CSDL
        }

        private void dgvKyluat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // CellDoubleClick ý tưởng dùng để khi click vào sinh viên thì hiện ra bảng from cập nhật SV
            if (e.RowIndex >= 0)
            {
                var msv = dgvKyluat.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                // truyền msv vào from sinh viên
                new UpdateKyLuat(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadDSKL();
            }
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            
            if (rbtlan1.Checked == true)
            {
                keys = "1";
            }
            else if (rbtlan2.Checked == true)
            {
                keys = "2";
            }
            List<CustomParameter> listPara = new List<CustomParameter>();
            listPara.Add(new CustomParameter()
            {
                key = "@keys",
                value = keys
            });
            // load all sinh vien khi from dc load
            dgvKyluat.DataSource = new Database().SelectData("KLnumber", listPara);

            dgvKyluat.Columns["tenlop"].HeaderText = "Tên Lớp";
            dgvKyluat.Columns["maSV"].HeaderText = "Mã Sinh Viên";
            dgvKyluat.Columns["hoten"].HeaderText = "Họ và Tên";
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLop.SelectedIndex == 0)
            {
                loadDSKL();
            }
            else
            {
                string lop = cbLop.SelectedValue.ToString();
                List<CustomParameter> listPara = new List<CustomParameter>();
                listPara.Add(new CustomParameter()
                {
                    key = "@keys",
                    value = lop
                });
                // load all sinh vien khi from dc load
                dgvKyluat.DataSource = new Database().SelectData("SelectAllKyluat", listPara);

                dgvKyluat.Columns["tenlop"].HeaderText = "Tên Lớp";
                dgvKyluat.Columns["maSV"].HeaderText = "Mã Sinh Viên";
                dgvKyluat.Columns["hoten"].HeaderText = "Họ và Tên";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvKyluat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
