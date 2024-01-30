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
    public partial class SVinClass : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        string lop;
        string keys = "";
        public SVinClass(string lop)
        {
            InitializeComponent();
            this.lop = lop;
        }
        string sql = "";
        private void SVinClass_Load(object sender, EventArgs e)
        {
            this.Text = "Danh Sách Sinh Viên Của Lớp '" + lop + "'";
            sql = "select tenlop,tenNganh from lop where tenlop = '" + lop + "'";
            var r = new Database().Select(sql);
            lbltenlop.Text = r["tenlop"].ToString();
            lblnganh.Text = r["tenNganh"].ToString();
            SVlop();
            Load_cblop();
        }
        public void SVlop()
        {
            keys = txtSearch.Text;
            string sql = "SelectDSlop";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { key = "@lop", value = lop });
            list.Add(new CustomParameter() { key = "@keys", value = keys });
            dgvSVlop.DataSource = new Database().SelectData(sql, list);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SVlop();
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

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            string lop = cblop.SelectedValue.ToString();
            string msv = txtchuyen.Text.ToString();
            sql = "chuyenlop";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { key = "@maSv", value = msv });
            list.Add(new CustomParameter() { key = "@lop", value = lop });
            var rs = new Database().Execute(sql, list);
            if(rs == 1)
            {
                MessageBox.Show("chuyển Thành Công");
                SVlop();

            }
        }

        private void dgvSVlop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSVlop.Rows[e.RowIndex].Cells["maSV"].Value.ToString();
                txtchuyen.Text = msv;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
