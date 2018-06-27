using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ReportByTerm_DTO
    {
        string TermID { get; set; }
        string ClassID { get; set; }
        int NumberOfPassed { get; set; }
        double PercentOfPassed { get; set; }
    }
}
