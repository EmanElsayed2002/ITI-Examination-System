using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
