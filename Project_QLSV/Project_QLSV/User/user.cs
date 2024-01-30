using Project_QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            // from main này dùng để hiển thị điểm sinh viên
            // nên tạm thời 
            var db = new Database(); // create obj database
            //dgvData.DataSource = db.SelectData(null); // hiển thị Data ra grv
        }


        public void outuser() { Close(); }
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (txtUser.Text == "admin" && txtPass.Text == "admin")
                {
                    //FrmDSSV ds = new FrmDSSV();
                    //ds.ShowDialog();
                    txtUser.Text = "";
                    txtPass.Text = "";
                    new FrmMain().ShowDialog();
                }
                else
                {
                    if (txtUser.Text != "admin")
                    {
                        MessageBox.Show("Tài khoản Không đúng !!");
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Không đúng !!");
                    }
                }

            }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            new ForgetACC().ShowDialog();
        }
    }   
    }

