using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV.Kỷ_Luật
{
    public partial class UpdateKyLuat : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        string msv;
        public UpdateKyLuat(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void UpdateKyLuat_Load(object sender, EventArgs e)
        {
            Load_cblop();
            Load_cbNam();
            this.Text = "Cập nhật thông tin Sinh Viên";
            // lấy thông tin chi tiết của 1 sinh viên của msv dc truyền vào
            var r = new Database().Select("SelectSVKL '" + msv + "'");

            // MessageBox.Show(r[0].ToString()); hiển thị thành công
            lblOutMvs.Text = r["maSV"].ToString();
            lblHoTen.Text = r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
            if (r["number"].ToString() == "1" )
            {
                radLan1.Checked = true;
            }
            else { radlan2.Checked = true; }
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

        string number = "";
        string sql = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "UpdateKyLuat";
            if (radlan2.Checked)
            {
                number = "2";
            }
            string ghi = txtghi.Text;
            List<CustomParameter> list = new List<CustomParameter>(); 
            list.Add(new CustomParameter()
            {
                key = "@maSv",
                value = msv,
            });

            list.Add(new CustomParameter()
            {
                key = "@number",
                value = number,
            });
            list.Add(new CustomParameter()
            {
                key = "@ghichu",
                value = ghi,
            });
            var rs = new Database().Execute(sql,list);
            if (rs == 1) // thực thi thành công
            {
                if (string.IsNullOrEmpty(msv)) // nếu thêm mới
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else // nếu cập nhật
                {
                    MessageBox.Show("cập nhật thành công");
                }
                this.Dispose();// đóng from sau khi thêm mới/ update
            }
            else
            {
                MessageBox.Show("thực thi thất bại");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn Xóa ??",
                "Thông báo!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(msv))
                {
                    sql = "DeleteSVKL";
                    list.Add(new CustomParameter()
                    {
                        key = "@maSV",
                        value = msv
                    });
                }
                var rs = new Database().Delete(sql, list);
                MessageBox.Show("Xóa Thành Công");
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
