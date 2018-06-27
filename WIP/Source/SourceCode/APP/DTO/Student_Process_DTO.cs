using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student_Process_DTO
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string TermID { get; set; }
        public double TotalFinalScore { get; set; }
    }
}
