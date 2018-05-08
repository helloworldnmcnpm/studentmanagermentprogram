using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailScore_DTO
    {
        public string ID { get; set; }
        //ID of Score by Subject
        public string SBSID { get; set; }
        public string TypeExamID { get; set; }
        public float Score { get; set; }
    }
}
