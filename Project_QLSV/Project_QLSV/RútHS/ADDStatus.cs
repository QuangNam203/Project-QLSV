using Project_QLSV.Class_Sinh_Viên;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV.RútHS
{
    public partial class ADDStatus : Form
    {
        string msv;
        public ADDStatus(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            string status = "1";
            string sql = "Upstatus";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { key = "@maSV", value = msv });
            list.Add(new CustomParameter() { key = "@statuss", value = status });
            var rs = new Database().Execute(sql, list);
            if (rs == 1) // thực thi thành công
            {
                MessageBox.Show("cập nhật thành công");
                new FrmStatus().loadstatus(status);
                this.Dispose();// đóng from sau khi thêm mới/ update
            }
            else
            {
                MessageBox.Show("thực thi thất bại");
            }
        }

        private void UpStatus_Load(object sender, EventArgs e)
        {
            string sql = "select maSV,tenlop,ho,tendem,ten from sinhvien where  maSV = '"+msv+"'";
            var r = new Database().Select(sql);
            lblma.Text = r["maSV"].ToString();
            lbllop.Text = r["tenlop"].ToString();
            lblten.Text = r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            string sql = "select maSV,firstyear,lastyear from sinhvien,khoahoc where maSV = '" + msv + "' AND sinhvien.khoa = khoahoc.khoa ";
            var r = new Database().Select(sql);
            int F = int.Parse(r["firstyear"].ToString());
            int L = int.Parse(r["lastyear"].ToString());
            if((L - F) >= 1)
            {
                string status = "0";
                sql = "Upstatus";
                List<CustomParameter> list = new List<CustomParameter>();
                list.Add(new CustomParameter() { key = "@maSV", value = msv });
                list.Add(new CustomParameter() { key = "@statuss", value = status });
                var rs = new Database().Execute(sql, list);
                if (rs == 1) // thực thi thành công
                {
                    MessageBox.Show("cập nhật thành công");
                    new FrmStatus().loadstatus(status);
                    this.Dispose();// đóng from sau khi thêm mới/ update
                }
                else
                {
                    MessageBox.Show("thực thi thất bại");
                }
            }  
        }
    }
}
