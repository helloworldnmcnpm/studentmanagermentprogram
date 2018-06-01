using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SchoolYear_DAL
    {
        public static List<SchoolYear_DTO> Load()
        {     
            DataTable dt = DataProvider.dataTableQuery(@"select * from NAMHOC");
            if (dt!=null && dt.Rows.Count > 0)
            {
                List<SchoolYear_DTO> schoolYear_DTOs = new List<SchoolYear_DTO>();
                SchoolYear_DTO sy;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sy = new SchoolYear_DTO();
                    sy.ID = dt.Rows[i]["MaNamHoc"].ToString();
                    sy.Begin = Convert.ToInt32(dt.Rows[i]["TuNam"].ToString());
                    sy.End = Convert.ToInt32(dt.Rows[i]["DenNam"].ToString());
                    schoolYear_DTOs.Add(sy);
                }
                return schoolYear_DTOs;
            }
            return null;
        }
        public static bool Insert(SchoolYear_DTO schoolYear_DTO)
        {
            return DataProvider.ExecuteNonQueryMethod(string.Format("Insert into NAMHOC(MaNamHoc,TuNam,DenNam) values('{0}','{1}','{2}')", schoolYear_DTO.ID, schoolYear_DTO.Begin, schoolYear_DTO.End));
        }
        public static bool Update(SchoolYear_DTO SchoolYearDTO)
        {
            string QueryString = string.Format("Update NAMHOC set TuNam='{0}' DenNam='{1}' Where MaNamHoc='{2}'", SchoolYearDTO.Begin, SchoolYearDTO.End, SchoolYearDTO.ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool Delete(string ID)
        {
            return DataProvider.ExecuteNonQueryMethod(string.Format("Delete from NAMHOC where MaNamHoc='{0}'", ID));
        }
    }
}
