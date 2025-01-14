using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination
{
    public class Department
    {
        public int Dept_ID { get; set; }
        public string DeptName { get; set; }
        public int? BranchID { get; set; }
        public int? ManagerID { get; set; }
    }
}
