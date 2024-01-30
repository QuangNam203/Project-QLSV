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
    public partial class FrmSinhVien : Form
    {
        public static List<string> columnData = new List<string>();
        
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmDSSV_Load(object sender, EventArgs e)
        {
            loadDSSV();// gọi tới hàm load sinh viên from
        }

        string keys = "";
        private void loadDSSV()
        {

            keys = txtSearch.Text;
            List<CustomParameter> listPara = new List<CustomParameter>();
            listPara.Add(new CustomParameter()
            {
                key = "@keys",
                value = keys
            });
            // load all sinh vien khi from dc load
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien",listPara);

            // đặt tên cho cột trong bảng
            dgvSinhVien.Columns["tenlop"].HeaderText = "Tên Lớp";
            dgvSinhVien.Columns["maSV"].HeaderText = "Mã Sinh Viên";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ và Tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["dantoc"].HeaderText = "Dân Tộc";
            dgvSinhVien.Columns["tencha"].HeaderText = "Tên Cha";
            dgvSinhVien.Columns["tenme"].HeaderText = "Tên Mẹ";


            dgvSinhVien.Columns["tennganh"].HeaderText = "Tên Ngành";

            foreach (DataGridViewRow row in dgvSinhVien.Rows) // duyệt số dòng
            {
                if (row.Cells[dgvSinhVien.Columns["maSV"].Index].Value != null) // KT xem dòng của cột tenlop đến null chưa
                {
                    var cellValue = row.Cells[dgvSinhVien.Columns["maSV"].Index].Value.ToString(); // gán bằng 1 obj
                    columnData.Add(cellValue); // add vào list
                }
            }

        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // CellDoubleClick ý tưởng dùng để khi click vào sinh viên thì hiện ra bảng from cập nhật SV
            if(e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                // truyền msv vào from sinh viên
                new UpdateSV(msv).ShowDialog();

                // sau khi from Sinh viên đc đóng
                // thì cần phải load lại DSSV
                loadDSSV();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ADDSV(null).ShowDialog(); // nếu thêm mới thì msv = null
            // ngay add xong TT kết thúc from thì load lại
            loadDSSV(); // khi thêm mới xong thì load lại CSDL
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadDSSV();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
