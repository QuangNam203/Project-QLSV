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

namespace Project_QLSV.RútHS
{
    public partial class FrmStatus : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        string keys = "";
        static string status;
        public FrmStatus()
        {
            InitializeComponent();
        }

        private void FrmRut_Load(object sender, EventArgs e)
        {
            loadCheck();
        }
        public void loadstatus(string statu)
        {
            keys = "";
            status = statu;
            string sql = "QLstatus";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { key = "@statuss", value = status });
            list.Add(new CustomParameter() { key = "@keys", value = keys });
            dgvRut.DataSource = new Database().SelectData(sql, list);
        }
        public void loadCheck()
        {
            keys = txtSearch.Text;
            string sql = "checkSV";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { key = "@keys", value = keys });
            dgvCheck.DataSource = new Database().SelectData(sql, list);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadCheck();
        }
      
        private void dgvCheck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvCheck.Rows[e.RowIndex].Cells["maSV"].Value.ToString();
                 // truyền msv vào from sinh viên
                new ADDStatus(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadstatus(status);
            }
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbstatus.SelectedItem == "Withdraw")
            {
                string a = "1";
                status = a;
                loadstatus(a);
            }
            else if(cbstatus.SelectedItem == "Reserve")
            {
                string a = "0";
                status = a;
                loadstatus(a);
            }
        }

        private void dgvRut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvRut.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                // truyền msv vào from sinh viên
                new UpdateStatus(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadstatus(status);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
