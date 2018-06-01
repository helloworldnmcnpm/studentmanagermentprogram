using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class Subject_BUL
    {
        public static List<Subject_DTO> Load()
        {
            return Subject_DAL.Load();
        }
        public static bool Insert(Subject_DTO subject_DTO)
        {
            return Subject_DAL.Insert(subject_DTO);
        }
        public static bool Update(Subject_DTO subject_DTO)
        {
            return Subject_DAL.Update(subject_DTO);
        }
        public static bool Delete(string ID)
        {
            return Subject_DAL.Delete(ID);
        }
    }
}
