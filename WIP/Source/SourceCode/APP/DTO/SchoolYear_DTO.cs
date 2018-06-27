using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SchoolYear_DTO
    {
       
        public string ID { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
        
        public string Name
        {
            get
            {
                return Begin + "-" + End ;
            }

            set
            {
                Name = Begin+ "-" + End;
            }
        }
    }
}
