using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ScoreBySubject_DTO
    {
        public string ID { get; set; }
        public int ProcessID { get; set; }
        public string SubjectID { get; set; }
        public float FinalScore { get; set; }
    }
}
