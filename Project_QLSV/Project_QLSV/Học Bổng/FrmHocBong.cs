using Project_QLSV.Khen_Thưởng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV.Học_Bổng
{
    public partial class FrmHocBong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        public FrmHocBong()
        {
            InitializeComponent();
        }

        private void FrmHocBong_Load(object sender, EventArgs e)
        {
            loadDSHB(); // load DS
            Load_cblop();
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
        string keys = "";
        private void loadDSHB()
        {
            keys = txtSearch.Text;
            List<CustomParameter> listPara = new List<CustomParameter>();
            listPara.Add(new CustomParameter()
            {
                key = "@keys",
                value = keys
            });
            // load all học bổng khi from dc load
            dgvHocBong.DataSource = new Database().SelectData("SelectAllHocBong", listPara);

            // đặt tên cho cột trong bảng
            dgvHocBong.Columns["tenlop"].HeaderText = "Tên Lớp";
            dgvHocBong.Columns["maSV"].HeaderText = "Mã Sinh Viên";
            dgvHocBong.Columns["hoten"].HeaderText = "Họ và Tên";
            dgvHocBong.Columns["loai"].HeaderText = "Mức Học Bổng";
            dgvHocBong.Columns["namhoc"].HeaderText = "Năm Học";

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new ADDHocBong(null).ShowDialog();
            loadDSHB();
        }

        private void dgvHocBong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvHocBong.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                // truyền msv vào from sinh viên
                new UpdateHocBong(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadDSHB() ;
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedIndex == 0)
            {
                loadDSHB();
            }
            if(cbLop.SelectedIndex != 0)
            {
                string lop = cbLop.SelectedValue.ToString();
                List<CustomParameter> listPara = new List<CustomParameter>();
                listPara.Add(new CustomParameter()
                {
                    key = "@keys",
                    value = lop
                });
                // load all sinh vien khi from dc load
                dgvHocBong.DataSource = new Database().SelectData("SelectAllHocBong", listPara);

                dgvHocBong.Columns["tenlop"].HeaderText = "Tên Lớp";
                dgvHocBong.Columns["maSV"].HeaderText = "Mã Sinh Viên";
                dgvHocBong.Columns["hoten"].HeaderText = "Họ và Tên";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbLop.SelectedIndex = 0;
            loadDSHB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
