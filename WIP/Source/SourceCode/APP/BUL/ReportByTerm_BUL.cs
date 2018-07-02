using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class ReportByTerm_BUL
    {
        public static List<ReportByTerm_DTO> Load(string TermID)
        {
            return ReportByTerm_DAL.Load(TermID);
        }
        public static bool Insert(string TermID, string ClassID, int NumberPass, double PercentPass)
        {
            return ReportByTerm_DAL.Insert(TermID, ClassID, NumberPass, PercentPass);
        }
    }
}
