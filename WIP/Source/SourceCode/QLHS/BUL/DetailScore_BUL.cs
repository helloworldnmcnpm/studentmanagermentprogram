using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class DetailScore_BUL
    {
        public static bool InsertScoreByStudent(string ScoreBySubjectID, string TypeExamID, float Score)
        {
            return DeTailScore_DAL.InsertScoreByStudent(ScoreBySubjectID, TypeExamID, Score);
        }
        public static List<DetailScore_DTO> LoadBySBSID(string ScoreBySubjectID)
        {
            return DeTailScore_DAL.LoadBySBSID(ScoreBySubjectID);
        }

        public static bool DeleteScoreByStudent(int ID)
        {
            return DeTailScore_DAL.DeleteScoreByStudent(ID);
        }
        public static bool UpdateScoreByStudent(int ID, float Score)
        {
            return DeTailScore_DAL.UpdateScoreByStudent(ID, Score);
        }
    }
}
