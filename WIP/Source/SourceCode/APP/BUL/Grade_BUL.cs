using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Grade_BUL
    {
        public static List<Grade_DTO> Load()
        {
            return Grade_DAL.Load();
        }
        public static bool Insert(Grade_DTO grade_DTO)
        {
            return Grade_DAL.Insert(grade_DTO);
        }
        public static bool Update(Grade_DTO grade_DTO)
        {
            return Grade_DAL.Update(grade_DTO);
        }
        public static bool Delete(string ID)
        {
            return Grade_DAL.Delete(ID);
        }
    }
}
