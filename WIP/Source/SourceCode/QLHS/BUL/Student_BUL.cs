using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class Student_BUL
    {
        public static List<Student_DTO> Load()
        {
            return Student_DAL.Load();
        }
        public static bool Insert(Student_DTO stdDTO)
        {
            return Student_DAL.Insert(stdDTO);
        }
        public static bool Update(Student_DTO stdDTO)
        {
            return Student_DAL.Update(stdDTO);
        }
        public static bool Delete(int ID)
        {
            return Student_DAL.Delete(ID);
        }
        public static bool ChangeClass(int StudentID, string TermID, string ClassID)
        {
            return Student_DAL.ChangeClass(StudentID, TermID, ClassID);
        }
    }
}
