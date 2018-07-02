using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ReportByTerm_DAL
    {
        public static List<ReportByTerm_DTO> Load(string TermID)
        {
            string QueryString = string.Format("Select * from BAOCAOTONGKETHOCKY where (MaHocKy='{0}')", TermID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null && dt.Rows.Count > 0)
            {
                List<ReportByTerm_DTO> reportByTerm_DTOs = new List<ReportByTerm_DTO>();
                ReportByTerm_DTO reportByTerm_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    reportByTerm_DTO = new ReportByTerm_DTO();
                    reportByTerm_DTO.TermID = dt.Rows[i]["MaHocKy"].ToString();
                    reportByTerm_DTO.ClassID = dt.Rows[i]["MaLop"].ToString();
                    reportByTerm_DTO.NumberOfPassed = Convert.ToInt32(dt.Rows[i]["SoLuongDat"].ToString());
                    reportByTerm_DTO.PercentOfPassed = Convert.ToDouble(dt.Rows[i]["TyLeDat"].ToString());
                    reportByTerm_DTOs.Add(reportByTerm_DTO);
                }
                return reportByTerm_DTOs;
            }
            return null;
        }

        public static bool Insert(string TermID,string ClassID, int NumberPass, double PercentPass)
        {
            string QueryString = string.Format("Insert into BAOCAOTONGKETHOCKY(MaHocKy,MaLop,SoLuongDat,TyLeDat) values('{0}','{1}','{2}','{3}')", TermID, ClassID, NumberPass, PercentPass);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
    }
}
