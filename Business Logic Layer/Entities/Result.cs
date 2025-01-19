using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Entities
{
    public class Result
    {
        public int ResultID { get; set; }
        public int StudentID { get; set; }
        public int ExamID { get; set; }
        public double Score { get; set; }
    }

}
