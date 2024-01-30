using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV.User
{
    public partial class ShowACC : Form
    {

        string use;
        string gmail;
        string sdt;
        public ShowACC(string use ,string gmail,string sdt)
        {
            InitializeComponent();
            this.use = use;
            this.gmail = gmail;
            this.sdt = sdt;
        }

        private void ShowACC_Load(object sender, EventArgs e)
        {
            
            this.Text = "Cập nhật thông tin Sinh Viên";
            // lấy thông tin chi tiết của 1 sinh viên của msv dc truyền vào
            var r = new Database().Select("ForgotACC '" + use + "','" + gmail + "','" + sdt + "'");

            // MessageBox.Show(r[0].ToString()); hiển thị thành công
            lblUse.Text = r["users"].ToString();
            lblPass.Text = r["pass"].ToString();
        }
    }
}
