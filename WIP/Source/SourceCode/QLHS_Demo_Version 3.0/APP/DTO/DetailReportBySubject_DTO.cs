using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DetailReportBySubject_DTO
    {
        string ID { get; set; }
        string ReportBySubjectID { get; set; }
        string ClassID { get; set; }
        int NumberPassed { get; set; }
        double PercentPassed { get; set; }
    }
}
