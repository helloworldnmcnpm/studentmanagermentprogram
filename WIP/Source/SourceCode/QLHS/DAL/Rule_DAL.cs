using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Rule_DAL
    {
        public static Rule_DTO Load()
        {
            Rule_DTO RuleDTO = new Rule_DTO();
            string QueryString = @"Select * from QUYDINH";
            DataTable dt = DataProvider.dataTableQuery(QueryString);
            RuleDTO.MaxAge = Convert.ToInt32(dt.Rows[0]["TuoiToiDa"].ToString());
            RuleDTO.MinAge = Convert.ToInt32(dt.Rows[0]["TuoiToiThieu"].ToString());
            RuleDTO.MaxStudent = Convert.ToInt32(dt.Rows[0]["SoHocSinhToiDa"].ToString());
            RuleDTO.PassedScore = Convert.ToSingle(dt.Rows[0]["DiemDat"].ToString());
            return RuleDTO;
        }
        public static bool UpdateRules(Rule_DTO RulesDTO)
        {
            string QueryString = string.Format("UPDATE QUYDINH set TuoiToiThieu='{0}', TuoiToiDa='{1}', SoHocSinhToiDa='{2}', DiemDat='{3}'", RulesDTO.MinAge, RulesDTO.MaxAge, RulesDTO.MaxStudent, RulesDTO.PassedScore);
            bool Result = DataProvider.ExecuteNonQueryMethod(QueryString);
            return Result;
        }
    }
}
