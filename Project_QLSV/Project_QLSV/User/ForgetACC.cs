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

namespace Project_QLSV.User
{
    public partial class ForgetACC : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
       
        public ForgetACC()
        {
            InitializeComponent();
        }

        private void ForgetACC_Load(object sender, EventArgs e)
        {
            loadACC();
        }
        
        private void loadACC()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            String sql = "select * from Taikhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;

            DataTable tb = new DataTable();
            ad.Fill(tb);
            cmd.Dispose();
            conn.Close();
            dgvACC.DataSource = tb;
        }
        static string otp;

        private void btnRest_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            var n = rd.Next(1000,9999);
            lblsms.Text = n.ToString();
            otp = lblsms.Text;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtSMS.Text == otp && chbrobot.Checked == true)
            {
                string use = txtUser.Text;
                string gmail = txtgmail.Text;
                string sdt = txtSDT.Text;
                if (txtSMS.Text == otp)
                {
                    new ShowACC(use, gmail, sdt).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mã Xác Nhận Không đúng !!");
                }
            }
            else
            {
                return;
            }
        }
    }
}
