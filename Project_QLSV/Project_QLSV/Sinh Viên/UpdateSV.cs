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

namespace Project_QLSV
{
    public partial class UpdateSV : Form
    {
        private string msv;
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        public UpdateSV(string msv)
        {
            this.msv = msv; // chuyền lại msv khi from chạy
            InitializeComponent();
        }
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật thông tin Sinh Viên";
            // lấy thông tin chi tiết của 1 sinh viên của msv dc truyền vào
            var r = new Database().Select("SelectSV '" + msv + "'");

            // MessageBox.Show(r[0].ToString()); hiển thị thành công
            txtHo.Text = r["ho"].ToString();
            txtTendem.Text = r["tendem"].ToString();
            txtTen.Text = r["ten"].ToString();
            mtbNgaysinh.Text = r["ngaysinh"].ToString();
            if (int.Parse(r["gioitinh"].ToString()) == 1)
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            txtSDT.Text = r["SĐT"].ToString();
            txtEmail.Text = r["Email"].ToString();
            txtAddres.Text = r["Addres"].ToString();
            txtCMND.Text = r["CMND"].ToString();
            txtMe.Text = r["tenme"].ToString();
            txtcha.Text = r["tencha"].ToString();
            txtDantoc.Text = r["dantoc"].ToString(); 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("ngay sinh khong hop le");
                mtbNgaysinh.Select();
                return;
            }
            string gioitinh = rbtNam.Checked ? "1" : "0"; // toán tử 3 ngôi
            string SDT = txtSDT.Text;
            string Email = txtEmail.Text;
            string Addres = txtAddres.Text;
            string CMND = txtCMND.Text;
            string cha = txtcha.Text;
            string me = txtMe.Text;
            string dan = txtDantoc.Text;
            List<CustomParameter> listPara = new List<CustomParameter>();
            sql = "UpdateSinhVien"; // gọi đến proce updatesinhvien
            listPara.Add(new CustomParameter()
            {
                key = "@maSV",
                value = msv
            });
            listPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            listPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            listPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            listPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            listPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            listPara.Add(new CustomParameter()
            {
                key = "@SĐT",
                value = SDT
            });
            listPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email
            });
            listPara.Add(new CustomParameter()
            {
                key = "@Addres",
                value = Addres
            });
            listPara.Add(new CustomParameter()
            {
                key = "@CMND",
                value = CMND
            });
            listPara.Add(new CustomParameter()
            {
                key = "@tencha",
                value = cha
            });
            listPara.Add(new CustomParameter()
            {
                key = "@tenme",
                value = me
            });
            listPara.Add(new CustomParameter()
            {
                key = "@dantoc",
                value = dan
            });
            var rs = new Database().Execute(sql, listPara); // truyền 2 tham số vào SQL

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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
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
                    sql = "DeleteSV";
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

      
    }
}
