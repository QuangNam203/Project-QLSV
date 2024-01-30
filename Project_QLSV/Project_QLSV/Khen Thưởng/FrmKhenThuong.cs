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

namespace Project_QLSV.Khen_Thưởng
{
    public partial class FrmKhenThuong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        public FrmKhenThuong()
        {
            InitializeComponent();
        }

        private void FrmKhenThuong_Load(object sender, EventArgs e)
        {
            Load_cbNam();
            loadDS();
        }
        private void Load_cbNam()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select concat(firstyear,'-',lastyear) as namhoc from khoahoc", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["namhoc"] = "---Năm học---";
            tb.Rows.InsertAt(r, 0);

            cbNam.DataSource = tb;
            cbNam.DisplayMember = "namhoc";
            cbNam.ValueMember = "namhoc";
        }
        string keys = "";
        public void loadDS()
        {
            if (txtSearch.Text != null)
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
            dgvKhen.DataSource = new Database().SelectData("SelectKhen", listPara);

            dgvKhen.Columns["tenlop"].HeaderText = "Tên Lớp";
            dgvKhen.Columns["maSV"].HeaderText = "Mã Sinh Viên";
            dgvKhen.Columns["hoten"].HeaderText = "Họ và Tên";
            dgvKhen.Columns["loai"].HeaderText = "Khen Thưởng";
            dgvKhen.Columns["namhoc"].HeaderText = "Năm Học";
            dgvKhen.Columns["ghichu"].HeaderText = "Ghi Chú";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new ADDKhen(null).ShowDialog();
            loadDS();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNam.SelectedIndex != 0)
            {
                string year = cbNam.SelectedValue.ToString();
                List<CustomParameter> listPara = new List<CustomParameter>();
                listPara.Add(new CustomParameter()
                {
                    key = "@keys",
                    value = year
                });
                // load all sinh vien khi from dc load
                dgvKhen.DataSource = new Database().SelectData("SelectKhen", listPara);
            }
        }

        private void dgvKhen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvKhen.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                // truyền msv vào from sinh viên
                new UpdateKhen(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadDS();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbNam.SelectedIndex = 0;
            loadDS();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
