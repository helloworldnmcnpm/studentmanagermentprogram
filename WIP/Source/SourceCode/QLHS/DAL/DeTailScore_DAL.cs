using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DeTailScore_DAL
    {
        public static bool InsertScoreByStudent(string ScoreBySubjectID, string TypeExamID, float Score)
        {
            string QueryString = string.Format("Insert into CHITIETBANGDIEMMON(MaBangDiemMon,MaHinhThucKiemTra,Diem) values ('{0}','{1}','{2}')", ScoreBySubjectID, TypeExamID, Score);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }

        public static bool DeleteScoreByStudent(int ID)
        {
            string QueryString = string.Format("Delete from CHITIETBANGDIEMMON where MaChiTietBangDiemMon = '{0}'", ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }

        public static bool UpdateScoreByStudent(int ID,float Score)
        {
            string QueryString = string.Format("Update CHITIETBANGDIEMMON set Diem='{0}' where MaChiTietBangDiemMon='{1}'", Score, ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }


        public static List<DetailScore_DTO> LoadBySBSID(string ScoreBySubjectID)
        {
            string QueryString = string.Format("Select * from CHITIETBANGDIEMMON where MaBangDiemMon='{0}'", ScoreBySubjectID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DetailScore_DTO> detailScore_DTOs = new List<DetailScore_DTO>();
                DetailScore_DTO detailScore_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    detailScore_DTO = new DetailScore_DTO();
                    detailScore_DTO.ID = dt.Rows[i]["MaChiTietBangDiemMon"].ToString();
                    detailScore_DTO.SBSID = dt.Rows[i]["MaBangDiemMon"].ToString();
                    detailScore_DTO.TypeExamID = dt.Rows[i]["MaHinhThucKiemTra"].ToString();
                    detailScore_DTO.Score = Convert.ToSingle(dt.Rows[i]["Diem"].ToString());
                    detailScore_DTOs.Add(detailScore_DTO);
                }
                return detailScore_DTOs;
            }
            return null;

        }
    }
}
