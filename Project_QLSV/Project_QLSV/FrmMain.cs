using Project_QLSV.Class_Sinh_Viên;
using Project_QLSV.Học_Bổng;
using Project_QLSV.Khen_Thưởng;
using Project_QLSV.RútHS;
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
    public partial class FrmMain : Form
    {
        bool Hided;

        public FrmMain()
        {
            InitializeComponent();
            Hided = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }
        // tạo hiệu ứng cho list menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                panel1.Height = panel1.Height + 20;
                if (panel1.Height == 301)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Height = panel1.Height - 20;
                if (panel1.Height == 1)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // add hiệu ứng cho các mục
        private void lblDS_MouseEnter(object sender, EventArgs e)
        {
            lblDS.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void lblDS_MouseLeave(object sender, EventArgs e)
        {
            lblDS.ForeColor = System.Drawing.Color.Black;
        }

        private void lblhocbong_MouseEnter(object sender, EventArgs e)
        {
            lblhocbong.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void lblhocbong_MouseLeave(object sender, EventArgs e)
        {
            lblhocbong.ForeColor = System.Drawing.Color.Black;
        }

        private void lblkhen_MouseEnter(object sender, EventArgs e)
        {
            lblkhen.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }
        private void lblkhen_MouseLeave(object sender, EventArgs e)
        {
            lblkhen.ForeColor = System.Drawing.Color.Black;
        }

        private void lblKyluat_MouseEnter(object sender, EventArgs e)
        {
            lblKyluat.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void lblKyluat_MouseLeave(object sender, EventArgs e)
        {
            lblKyluat.ForeColor = System.Drawing.Color.Black;
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            
            if (pic20.Visible == true)
            {
                pic20.Visible = false;
                picCN.Visible = true;
            }
            else if(picCN.Visible == true)
            {
                pic20.Visible = true;
                picCN.Visible = false;
            }
            
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (pic20.Visible == true)
            {
                pic20.Visible = false;
                picCN.Visible = true;
            }
            else if (picCN.Visible == true)
            {
                pic20.Visible = true;
                picCN.Visible = false;
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn Thoát không ??",
                "Thông báo!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lblDS_Click(object sender, EventArgs e)
        {
            FrmSinhVien  sv = new FrmSinhVien();
            sv.ShowDialog();
        }

        private void lblKyluat_Click(object sender, EventArgs e)
        {
            new FrmKyLuat().ShowDialog();
        }

        private void lblkhen_Click(object sender, EventArgs e)
        {
            new FrmKhenThuong().ShowDialog();
        }

        private void lblhocbong_Click(object sender, EventArgs e)
        {
            new FrmHocBong().ShowDialog();
        }

        private void lblDSSV_Click(object sender, EventArgs e)
        {
            new Class().ShowDialog();
        }

        private void lblDSSV_MouseEnter(object sender, EventArgs e)
        {
            lblDSLop.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void lblDSSV_MouseLeave(object sender, EventArgs e)
        {
            lblDSLop.ForeColor = System.Drawing.Color.Black;
        }

        private void lblHS_Click(object sender, EventArgs e)
        {
            new FrmStatus().ShowDialog();
        }

        private void lblHS_MouseEnter(object sender, EventArgs e)
        {
            lblHS.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void lblHS_MouseLeave(object sender, EventArgs e)
        {
            lblHS.ForeColor = System.Drawing.Color.Black;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Black;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Black;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Black;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.FromArgb(195, 142, 180);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Black;
        }
    }
}
