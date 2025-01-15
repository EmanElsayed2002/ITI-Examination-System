using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination
{
    public class Questions
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public int? courseID { get; set; }
        public int? grade { get; set; }
        public string? Question_Type { get; set; }
    }
}
