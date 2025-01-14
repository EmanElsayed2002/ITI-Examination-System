using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination
{
    public class Choice
    {
        public int ChoiceID { get; set; }
        public string? Answer { get; set; }
        public int? QuestionID { get; set; }
        public bool? Model_Ans { get; set; }
    }
}
