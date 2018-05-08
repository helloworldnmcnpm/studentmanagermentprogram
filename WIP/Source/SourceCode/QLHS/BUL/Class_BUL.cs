using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Class_BUL
    {
        public static List<Class_DTO> Load()
        {
            return Class_DAL.Load();
        }
        public static bool Delete(string ID)
        {
            return Class_DAL.Delete(ID);
        }
        public static bool Update(Class_DTO ClassDTO)
        {
            return Class_DAL.Update(ClassDTO);
        }
        public static bool Insert(Class_DTO ClassDTO)
        {
            return Class_DAL.Insert(ClassDTO);
        }
        public static bool UpdateNumberStudent(int i, string classID)
        {
            return Class_DAL.UpdateNumberStudent(i, classID);
        }
        public static List<Class_DTO> LoadBySC(string ID)
        {
            return Class_DAL.LoadBySC(ID);
        }
    }
}
