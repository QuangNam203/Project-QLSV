using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV
{
    public partial class ADDSV : Form
    {
        private string msv;
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");

        public ADDSV(string msv)
        {
            this.msv = msv; // chuyền lại msv khi from chạy
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(msv))// nếu không có msv thì mới hiện from sinh viên
            {
                this.Text = "Thêm mới sinh viên";
            }
            Load_cbKhoa();
            Load_cbnganh();
        }

        private void Load_cbKhoa()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from khoahoc", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["khoa"] = "---Chọn Khóa---";
            tb.Rows.InsertAt(r, 0);

            cbkhoa.DataSource = tb;
            cbkhoa.DisplayMember = "khoa";
            cbkhoa.ValueMember = "khoa";
        }
        private void Load_cbnganh()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from nganh", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["tenNganh"] = "---Chọn Ngành---";
            tb.Rows.InsertAt(r, 0);

            cbnganh.DataSource = tb;
            cbnganh.DisplayMember = "tenNganh";
            cbnganh.ValueMember = "tenNganh";

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // btnLuu sẽ xử lý 2 tình huống
            // 1: nếu msv = null -> thêm mới sinh viên
            // 2: nếu msv != null -> cập nhật sinh viên 
            Random rd = new Random();
            string xeplop = Convert.ToString(rd.Next(21,22));
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
            string SDT =txtSDT.Text;
            string Email = txtEmail.Text;
            string Addres = txtAddres.Text;
            string CMND =txtCMND.Text;
            string tennganh = cbnganh.SelectedValue.ToString();
            var r = new Database().Select("select MaNganh from Nganh where tenNganh = N'" + tennganh + "'");
            string lop = cbkhoa.SelectedValue.ToString() +""+ r["MaNganh"].ToString() + "" +xeplop;
            string malop = lop.Substring(0,6);
            string khoa = lop.Substring(0,2);
            string cha = txtcha.Text;
            string me = txtMe.Text;
            string dan = txtDantoc.Text;
            // kiểm tra msv để trả về TH
            List<CustomParameter> listPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv)) // msv = null
            {
                
                sql = "AddSinhVien"; // gọi đến proce Addsinhvien
                listPara.Add(new CustomParameter()
                {
                    key = "@tenlop",
                    value = lop
                });
            }
            listPara.Add(new CustomParameter(){key = "@malop",value = malop});
            listPara.Add(new CustomParameter(){key = "@ho",value = ho});
            listPara.Add(new CustomParameter(){key = "@tendem",value = tendem});
            listPara.Add(new CustomParameter(){key = "@ten",value = ten});
            listPara.Add(new CustomParameter(){key = "@ngaysinh",value = ngaysinh.ToString("yyyy-MM-dd")});
            listPara.Add(new CustomParameter(){key = "@gioitinh",value = gioitinh});
            listPara.Add(new CustomParameter(){key = "@SĐT",value = SDT});
            listPara.Add(new CustomParameter(){key = "@Email",value = Email});
            listPara.Add(new CustomParameter(){key = "@Addres",value = Addres});
            listPara.Add(new CustomParameter(){key = "@CMND",value = CMND});
            listPara.Add(new CustomParameter(){key = "@tencha",value = cha});
            listPara.Add(new CustomParameter(){key = "@tenme",value = me});
            listPara.Add(new CustomParameter(){key = "@dantoc",value = dan});
            listPara.Add(new CustomParameter(){key = "@tennganh",value = tennganh});
            listPara.Add(new CustomParameter() { key = "@khoa", value = khoa });

            var rs = new Database().Execute(sql, listPara); // truyền 2 tham số vào SQL
            //addSVAll(tenlop, masv, ho, tendem, ten, "ADDEvaluate"); // add Điểm xếp loại
            //addSVAll(tenlop,masv,ho,tendem,ten, "ADDHocphi"); // add sv trong học phí
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

        private void addSVAll(string tenlop,string masv,string ho,string tendem, string ten,string sql)
        {
            //string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();

            //sql = "ADDHocphi"; // gọi đến proce ADDHocphi
            list.Add(new CustomParameter(){key = "@tenlop",value = tenlop});
            list.Add(new CustomParameter(){key = "@maSV",value = masv});
            list.Add(new CustomParameter(){key = "@ho",value = ho});
            list.Add(new CustomParameter(){key = "@tendem",value = tendem});
            list.Add(new CustomParameter(){key = "@ten",value = ten});
            new Database().Execute(sql, list);
        }
    }
}
