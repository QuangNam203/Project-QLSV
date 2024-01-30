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
    public partial class UpdateStatus : Form
    {
        string msv;
        public UpdateStatus(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void UpdateStatus_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật thông tin Sinh Viên";
            // lấy thông tin chi tiết của 1 sinh viên của msv dc truyền vào
            var r = new Database().Select("SelectStatus '" + msv + "'");

            // MessageBox.Show(r[0].ToString()); hiển thị thành công
            lblten.Text = r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
            lblma.Text = r["maSV"].ToString();
            lbllop.Text = r["tenlop"].ToString();
            if (int.Parse(r["statuss"].ToString()) == 1)
            {
                rbtRut.Checked = true;
            }
            else
            {
                rbtBao.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string statuss = rbtRut.Checked ? "1" : "0"; // toán tử 3 ngôi
            List<CustomParameter> listPara = new List<CustomParameter>();
            sql = "UpdateStatus"; // gọi đến proce UpdateStatus
            listPara.Add(new CustomParameter(){key = "@maSV",value = msv,});
            listPara.Add(new CustomParameter() { key="@status",value = statuss,});
            var rs = new Database().Execute(sql,listPara);
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
                    sql = "DeleteStatus";
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
