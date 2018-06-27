using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Search_BUL
    {
        public static List<Student_DTO> SearchStudent(string NameLike)
        {
            return Search_DAL.SearchStudent(NameLike);
        }
    }
}
