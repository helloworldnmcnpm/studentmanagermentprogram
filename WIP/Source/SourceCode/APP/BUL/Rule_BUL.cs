using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class Rule_BUL
    {
        public static Rule_DTO Load()
        {
            return Rule_DAL.Load();
        }
        public static bool Update(Rule_DTO RulesDTO)
        {
            return Rule_DAL.UpdateRules(RulesDTO);
        }
    }
}
