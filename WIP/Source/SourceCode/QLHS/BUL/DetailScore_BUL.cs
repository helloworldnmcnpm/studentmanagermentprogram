using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class DetailScore_BUL
    {
        public List<DetailScore_DTO> LoadBySubject(string ID)
        {
            return DeTailScore_DAL.LoadBySubject(ID);
        }
        public static List<DetailScore_DTO> LoadByStudent(string StudentID, string TermID)
        {
            return DeTailScore_DAL.LoadByStudent(StudentID, TermID);
        }
    }
}
