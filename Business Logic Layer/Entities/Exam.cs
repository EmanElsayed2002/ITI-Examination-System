using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Entities
{
    public class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public string Subject { get; set; }
        public DateTime ExamDate { get; set; }
        public int InstructorID { get; set; }

        public int Duration { get; set; }
    }

}
