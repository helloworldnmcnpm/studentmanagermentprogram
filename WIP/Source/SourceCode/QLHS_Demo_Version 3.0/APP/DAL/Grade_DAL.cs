using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Grade_DAL
    {
        public static List<Grade_DTO> Load()
        {
            string QueryString = @"Select * from KHOI";
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Grade_DTO> ListGradeDTO = new List<Grade_DTO>();
                Grade_DTO gradeDTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gradeDTO = new Grade_DTO();
                    gradeDTO.ID = dt.Rows[i]["MaKhoi"].ToString();
                    gradeDTO.Name = dt.Rows[i]["TenKhoi"].ToString();
                    ListGradeDTO.Add(gradeDTO);
                }
                return ListGradeDTO;
            }
            return null;
        }
        public static bool Insert(Grade_DTO gradeDTO)
        {
            string QueryString = string.Format("Insert into KHOI(MaKhoi,TenKhoi) values('{0}',N'{1}')", gradeDTO.ID, gradeDTO.Name);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Update(Grade_DTO gradeDTO)
        {
            string QueryString = string.Format("UPDATE KHOI SET TenKhoi=N'{0}' Where MaKhoi='{1}'", gradeDTO.Name, gradeDTO.ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Delete(string ID)
        {
            string QueryString = String.Format("Delete From KHOI Where MaKhoi='{0}'",ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
    }
}
