using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Login_BUL
    {
        public static bool CheckPassword(Login_DTO Account)
        {
            return Login_DAL.CheckPassword(Account);
        }
        public static bool ChangePassword(string NewPassword, string TK)
        {
            return Login_DAL.ChangePassword(NewPassword, TK);
        }
    }
}
