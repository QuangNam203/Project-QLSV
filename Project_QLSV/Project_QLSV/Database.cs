using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV
{
    public class Database
    {
        SqlConnection conn = new SqlConnection("Data Source=1R0NY;Initial Catalog=72dctm22;Integrated Security=True");
        private DataTable dt;
        private SqlCommand cmd;
        public DataTable SelectData(string sql, List<CustomParameter> listPara)
        {
            try
            {   
                // kiểm xem conn có đóng không nếu đóng thì mở lên
                if(conn.State != ConnectionState.Closed)
                {
                    conn.Open();
                }
                // tạo Query cho SQL
                cmd = new SqlCommand(sql, conn); // chuyền Query và create conn
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in listPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }

                // tạo đối tượng dataAdater để lấy đối tượng từ cmd
                SqlDataAdapter adapter = new SqlDataAdapter(); 
                adapter.SelectCommand = cmd; // lấy OBJ cmd

                //lấy dữ liệu từ adapter dố sang datatable
                dt = new DataTable(); // create
                adapter.Fill(dt); // đấy obj -> datatable
               
                return dt; // trả về đối tượng
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        // hàm Select dùng để hiển thị TT 1 SV
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader()); // thực hiện câu lệnh
                return dt.Rows[0];

            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin" + ex.Message);
                return null;
            }
            finally 
            { 
                conn.Close();
            }
        }

        // hàm Execute dùng để gọi đến các Procedure
        public int Execute(string sql,List<CustomParameter> Parameter)
        {
            try
            {
                // string sql, list<parameter> parameter là tham số truyền vào
                conn.Open();// mở kết nối SQL
                cmd = new SqlCommand(sql, conn); // thực hiện truy vấn
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in Parameter) // gán tham số vào cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();// lấy kết quả thực hiện truy vấn
                return (int)rs; 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện câu lệnh"+ex.Message);
                return -100;
            }
            finally
                { conn.Close(); }
        }

        public int Delete(string sql, List<CustomParameter> Para)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in Para) // gán tham số vào cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();// lấy kết quả thực hiện truy vấn
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện câu lệnh" + ex.Message);
                return -100;
            }
            finally
            { conn.Close(); }

        }


    }
}
