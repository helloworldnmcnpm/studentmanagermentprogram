using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class TypeExam_BUL
    {
        public static List<TypeExam_DTO> Load()
        {
            return TypeExam_DAL.Load();
        }
        public static bool Insert(TypeExam_DTO typeExam_DTO)
        {
            return TypeExam_DAL.Insert(typeExam_DTO);
        }
        public static bool Update (TypeExam_DTO typeExam_DTO)
        {
            return TypeExam_DAL.Update(typeExam_DTO);
        }
        public static bool Delete (string ID)
        {
            return TypeExam_DAL.Delete(ID);
        }
    }
}
