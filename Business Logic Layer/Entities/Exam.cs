using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination
{
    public class Exam
    {
        public int Exam_ID { get; set; }
        public string ExamName { get; set; }
        public int? Num_of_MCQ { get; set; }
        public int? Num_of_TFQ { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }
    }
}
