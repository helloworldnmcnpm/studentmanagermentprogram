using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataProvider
    {
        //Thiết lập kết nối cơ sở dữ liệu qua Chuỗi kết nối
        public static SqlConnection Connect()
        {
            string ConnectionString = @"Data Source=DESKTOP-S2F14I7;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(ConnectionString);
            Conn.Open();
            return Conn;
        }
        //Thiết lập đóng kết nối cơ sở dữ liệu
        public static void Disconnected(SqlConnection conn)
        {
            conn.Close();
        }
        //Phương thức truy vấn cơ sở dữ liệu trả về kết quả là datatable. SELECT * FROM …

        public static DataTable dataTableQuery(string QueryString)
        {
            SqlConnection conn = Connect();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QueryString, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Disconnected(conn); return dt;
            }
            catch (Exception ex)
            {
                Disconnected(conn);
                return null;
            }
        }
        //Phương thức truy vấn cơ sở dữ liệu Insert, delete, change.. INSERT INTO …

        public static bool ExecuteNonQueryMethod(string QueryString)
        {
            SqlConnection conn = Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(QueryString, conn);
                int icmd = cmd.ExecuteNonQuery();
                Disconnected(conn);
                if (icmd > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                Disconnected(conn);
                return false;
            }
        }
        //Phương thức trả về 1 giá trị SELECT COUNT(*) FROM …

        public static string ExecuteScalaMethod(string QueryString)
        {
            SqlConnection conn = Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(QueryString, conn);
                string Result = cmd.ExecuteScalar().ToString();
                Disconnected(conn);
                return Result;
            }
            catch (Exception ex)
            {
                Disconnected(conn);
                return null;
            }
        }
    }
}
