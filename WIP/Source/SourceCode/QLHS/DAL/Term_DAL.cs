using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Term_DAL
    {
        public static List<Term_DTO> Load()
        {
            string QueryString = string.Format("Select * from HOCKY");
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Term_DTO> term_DTOs = new List<Term_DTO>();
                Term_DTO term_DTO;
                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    term_DTO = new Term_DTO();
                    term_DTO.ID = dt.Rows[i]["MaHocKy"].ToString();
                    term_DTO.Name = dt.Rows[i]["TenHocKy"].ToString();
                    term_DTO.SCID = dt.Rows[i]["MaNamHoc"].ToString();
                    term_DTOs.Add(term_DTO);
                }
                return term_DTOs;
            }
            return null;
        }
        public static bool Insert(Term_DTO term_DTO)
        {
            string QueryString = string.Format("Insert into HOCKY(MaHocKy,TenHocKy,MaNamHoc) values('{0}',N'{1}','{2}')", term_DTO.ID, term_DTO.Name, term_DTO.SCID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool Update(Term_DTO term_DTO)
        {
            string QueryString = string.Format("Update HOCKY set TenHocKy=N'{0}', MaNamHoc='{1}' where MaHocKy='{2}'", term_DTO.Name, term_DTO.SCID, term_DTO.ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool Delete(string ID)
        {
            return DataProvider.ExecuteNonQueryMethod(string.Format("Delete from HOCKY where MaHocKy='{0}'",ID));
        }
        public static List<Term_DTO> LoadBySC(string ID)
        {
            string QueryString = string.Format("select * from HOCKY where MaNamHoc='{0}'", ID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null&& dt.Rows.Count > 0)
            {
                List<Term_DTO> term_DTOs = new List<Term_DTO>();
                Term_DTO term_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    term_DTO = new Term_DTO();
                    term_DTO.ID = dt.Rows[i]["MaHocKy"].ToString();
                    term_DTO.Name = dt.Rows[i]["TenHocKy"].ToString();
                    term_DTO.SCID = dt.Rows[i]["MaNamHoc"].ToString();
                    term_DTOs.Add(term_DTO);
                }
                return term_DTOs;
            }
            return null;
        }
    }
}
