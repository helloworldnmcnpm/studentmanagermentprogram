using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportByTerm_DTO
    {
        public string TermID { get; set; }
        public string ClassID { get; set; }
        public int NumberOfPassed { get; set; }
        public double PercentOfPassed { get; set; }
    }
}
