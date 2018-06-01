using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ScoreBySubject_DAL
    {
        public static bool Insert(ScoreBySubject_DTO scoreBySubject_DTO)
        {
            string QueryString = string.Format("insert into BANGDIEMMON(MaBangDiemMon,MaQuaTrinhHoc,DiemTBM,MaMon) values('{0}','{1}','{2}','{3}')",
                scoreBySubject_DTO.ID, scoreBySubject_DTO.ProcessID, scoreBySubject_DTO.FinalScore, scoreBySubject_DTO.SubjectID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static List<ScoreBySubject_DTO> LoadByProcessID(int ID)
        {
            string QueryString = string.Format("Select * from BANGDIEMMON where MaQuaTrinhHoc='{0}'", ID);
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            if (dt!=null && dt.Rows.Count > 0)
            {
                List<ScoreBySubject_DTO> scoreBySubject_DTOs = new List<ScoreBySubject_DTO>();
                ScoreBySubject_DTO scoreBySubject_DTO;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    scoreBySubject_DTO = new ScoreBySubject_DTO();
                    scoreBySubject_DTO.ID = dt.Rows[i]["MaBangDiemMon"].ToString();
                    scoreBySubject_DTO.ProcessID =Convert.ToInt32(dt.Rows[i]["MaQuaTrinhHoc"].ToString());
                    scoreBySubject_DTO.FinalScore = Convert.ToSingle(dt.Rows[i]["DiemTBM"].ToString());
                    scoreBySubject_DTO.SubjectID = dt.Rows[i]["MaMon"].ToString();
                    scoreBySubject_DTOs.Add(scoreBySubject_DTO);
                }
                return scoreBySubject_DTOs;
            }
            return null;
        }
        public static string GetID(int ProcessID,string SubjectID)
        {
            List<ScoreBySubject_DTO> scoreBySubject_DTOs = LoadByProcessID(ProcessID);
            if (scoreBySubject_DTOs==null) return null;
            for (int i=0;i<scoreBySubject_DTOs.Count;i++)
            {
                if (scoreBySubject_DTOs[i].SubjectID == SubjectID) return scoreBySubject_DTOs[i].ID;
            }
            return null;
        }
        public static bool Delete(string ID)
        {
            string QueryString = string.Format("Delete From BANGDIEMMON where MaBangDiemMon='{0}'", ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
        public static bool UpdateScore(string ID, double score)
        {
            string QueryString = string.Format("Update BANGDIEMMON set DiemTBM='{0}' where MaBangDiemMon='{1}'", score, ID);
            return DataProvider.ExecuteNonQueryMethod(QueryString);
        }
    }
}
