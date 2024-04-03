using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_AI
{
    public class ProcessData
    {
        public DateTime datetime { get; set; }  // PK
        public float ReactA_Temp {  get; set; }
        public float ReactB_Temp { get;set; }
        public float ReactC_Temp { get; set; }
        public float ReactD_Temp { get; set; }
        public float ReactE_Temp { get;set;}
        public float ReactF_PH { get; set;  }
        public float Power { get; set; }
        public float CurrentA { get; set; } 
        public float CurrentB { get; set; } 
        public float CurrentC { get; set; }
    }
}
