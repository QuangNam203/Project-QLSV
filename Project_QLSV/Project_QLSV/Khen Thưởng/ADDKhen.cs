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
    public partial class ADDKhen : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        string msv;
        public ADDKhen(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void ADDKhen_Load(object sender, EventArgs e)
        {
            Load_cbKhen();
            Load_cbNam(); 
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string check = txtMaSV.Text.Trim();
            if (conn.State != ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "select maSV  from SinhVien";
            // tạo Query cho SQL
            SqlCommand cmd = new SqlCommand(sql, conn); // chuyền Query và create conn

            // tạo đối tượng dataAdater để lấy đối tượng từ cmd
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd; // lấy OBJ cmd

            //lấy dữ liệu từ adapter dố sang datatable
            DataTable dt = new DataTable(); // create
            adapter.Fill(dt); // đấy obj -> datatable
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (check.Equals(Convert.ToString(dt.Rows[i]["maSV"].ToString().Trim())))
                    {
                        MessageBox.Show("Có Thông Tin");
                        var r = new Database().Select("CheckSVKL '" + check + "'");
                        lbHoten.Text = r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
                        lblLop.Text = r["tenlop"].ToString();
                        return;
                    }
                MessageBox.Show("không có SV");
            }
            else
            {
                // Hiển thị thông báo khi không có dữ liệu trả về
                Console.WriteLine("Không có dữ liệu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btnLuu sẽ xử lý 2 tình huống
            // 1: nếu msv = null -> thêm mới sinh viên
            // 2: nếu msv != null -> cập nhật sinh viên

            string sql = "";
            string[] arrHoten = lbHoten.Text.Trim().Split(' ');
            string ho = arrHoten[0];
            string tendem = arrHoten[1];
            string ten = arrHoten[2];
            string lop = lblLop.Text.Trim();
            string masv = txtMaSV.Text;
            string nam = "";
            if (cbNam.SelectedIndex == 0)
            {
                MessageBox.Show("Lỗi Năm Học");
                return;
            }
            else { nam = cbNam.SelectedValue.ToString(); }
            string loai = cbKhen.SelectedValue.ToString() == "loai 1" ? "1" : "0";
            string ghi = txtghi.Text;
            // kiểm tra msv để trả về TH
            List<CustomParameter> listPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv)) // msv = null
            {
                sql = "ADDKhen"; // gọi đến proce AddKyLuat
                listPara.Add(new CustomParameter(){key = "@maSV",value = masv});
                listPara.Add(new CustomParameter(){key = "@tenlop",value = lop});
            }
            listPara.Add(new CustomParameter(){key = "@ho",value = ho});
            listPara.Add(new CustomParameter(){key = "@tendem",value = tendem});
            listPara.Add(new CustomParameter(){key = "@ten",value = ten});
            listPara.Add(new CustomParameter(){key = "@loai",value = loai});
            listPara.Add(new CustomParameter(){key = "@namhoc",value = nam});
            listPara.Add(new CustomParameter(){key = "@ghichu",value = ghi});

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
    }
}
