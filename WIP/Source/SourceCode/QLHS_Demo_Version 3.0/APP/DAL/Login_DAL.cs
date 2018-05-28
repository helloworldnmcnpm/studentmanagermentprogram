using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Login_DAL
    {
        public static bool CheckPassword(Login_DTO Account)
        {
            Login_DTO login_DTO = new Login_DTO();
            string QueryString = string.Format("Select * from TAIKHOANDANGNHAP where TenTaiKhoan='{0}' and MatKhau='{1}'",Account.Name,Account.Password);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
                return true;
            else return false;
        }
        public static bool ChangePassword(string NewPassword,string TK)
        {
            string QueryString = string.Format("Update TAIKHOANDANGNHAP set MatKhau='{0}' where TenTaiKhoan='{1}'", NewPassword,TK);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
    }
}
