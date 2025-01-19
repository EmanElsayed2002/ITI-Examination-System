using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Entities
{
    public class Option
    {
        public int OptionID { get; set; } 
        public string OptionText { get; set; } 
        public int QuestionID { get; set; } 
        public bool IsCorrect { get; set; } 
    }


}
