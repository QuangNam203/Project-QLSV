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

namespace Project_QLSV.Khen_Thưởng
{
    public partial class UpdateKhen : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        string msv;
        public UpdateKhen(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void UpdateKhen_Load(object sender, EventArgs e)
        {
            Load_cbKhen();
            this.Text = "Cập nhật thông tin Sinh Viên";
            // lấy thông tin chi tiết của 1 sinh viên của msv dc truyền vào
            string sql = "select tenlop, maSV,ho,tendem,ten from khenthuong where maSV = '" + msv + "'";
            var r = new Database().Select(sql);

            lblhoten.Text = r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
            lblmsv.Text = r["maSV"].ToString();
            lbllop.Text = r["tenlop"].ToString();
        }

        private void Load_cbKhen()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select thuong,case when loai = 1 then 'loai 1' else 'loai 2' end as loai from loai", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["loai"] = "---chọn loại---";
            tb.Rows.InsertAt(r, 0);

            cbKhen.DataSource = tb;
            cbKhen.DisplayMember = "loai";
            cbKhen.ValueMember = "loai";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string loai = cbKhen.SelectedValue.ToString() == "loai 1" ? "1" : "0";
            string sql = "UpdateKhen";
            List<CustomParameter> p = new List<CustomParameter>();
            p.Add(new CustomParameter() { key = "@loai", value = loai });
            p.Add(new CustomParameter() { key= "@maSV", value = msv });

            var rs = new Database().Execute(sql, p);
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
                    sql = "DeleteKhen";
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
