using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Subject_DAL
    {
        public static List<Subject_DTO> Load()
        {
            string QueryString = @"Select * from MON";
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Subject_DTO> ListSubjectDTO = new List<Subject_DTO>();
                Subject_DTO subjectDTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    subjectDTO = new Subject_DTO();
                    subjectDTO.ID = dt.Rows[i]["MaMon"].ToString();
                    subjectDTO.Name = dt.Rows[i]["TenMon"].ToString();
                    ListSubjectDTO.Add(subjectDTO);
                }
                return ListSubjectDTO;
            }
            return null;
        }
        public static bool Insert(Subject_DTO subjectDTO)
        {
            string QueryString = string.Format("Insert into MON(MaMon,TenMon) values('{0}',N'{1}')", subjectDTO.ID, subjectDTO.Name);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Update(Subject_DTO subjectDTO)
        {
            string QueryString = string.Format("UPDATE MON SET TenMon=N'{0}' Where MaMon='{1}'", subjectDTO.Name, subjectDTO.ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static bool Delete(string ID)
        {
            string QueryString = String.Format("Delete From MON Where MaMon='{0}'", ID);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
        public static string GetID(string Name)
        {
            string QueryString = string.Format("Select MaMon from MON where TenMon=N'{0}'", Name);
            string Result = DataProvider.ExecuteScalaMethod(QueryString);
            return Result;
        }
    }
}
