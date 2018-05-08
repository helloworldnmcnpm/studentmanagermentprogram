using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class SchoolYear_BUL
    {
        public static List<SchoolYear_DTO> Load()
        {
            return SchoolYear_DAL.Load();
        }
        public static bool Insert(SchoolYear_DTO schoolYear_DTO)
        {
            return SchoolYear_DAL.Insert(schoolYear_DTO);
        }
        public static bool Update(SchoolYear_DTO schoolYear_DTO)
        {
            return SchoolYear_DAL.Update(schoolYear_DTO);
        }
        public static bool Delete(string ID)
        {
            return SchoolYear_DAL.Delete(ID);
        }
    }
}
