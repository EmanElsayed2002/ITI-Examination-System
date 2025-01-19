using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.EntitiyManager
{
    public class StudentManager
    {
        public static bool isStudent(string email , string Password)
        {
            string query = "select * from Students where email=@email and Password=password";
            SqlParameter[] sp =
            {
                new SqlParameter ("email", email),
                new SqlParameter ("password", Password)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
