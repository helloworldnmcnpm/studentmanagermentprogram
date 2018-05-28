using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Process_DTO
    {
        public int ID { get; set; }
        public string ClassID { get; set; }
        public int StudentID { get; set; }
        public string TermID { get; set; }
        public double TotalScore { get; set; }
    }
}
