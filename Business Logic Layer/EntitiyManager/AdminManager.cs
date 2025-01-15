using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.EntitiyManager
{
    public class AdminManager
    {
        public static int AddInstructor(Instructor instructor)
        {
                string query = "INSERT INTO Instructors (InstructorName, Specialization, Email, Password) VALUES (@InstructorName, @Specialization, @Email, @Password)";
                SqlParameter[] sp ={
                    new SqlParameter("@InstructorName" , instructor.InstructorName),
                    new SqlParameter("@Specialization" , instructor.Specialization),
                    new SqlParameter("@Email" , instructor.Email),
                    new SqlParameter("@Password" , instructor.Password),
                };
                 int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
                 return rowsAffected;
        }

        public static List<Instructor> GetAllData()
        {
            string query = "Select * From Instructors";
            DataTable dt = new DataTable();
            List<Instructor> list = new List<Instructor>();
            foreach(DataRow dr in dt.Rows)
            {
                Instructor ins = new Instructor
                {
                    InstructorID = Convert.ToInt32(dr["InstructorID"]),
                    InstructorName = dr["InstructorName"].ToString(),
                    Specialization = dr["Specialization"].ToString(),
                    Email = dr["Email"].ToString(),
                    Password = dr["Password"].ToString()
                };
                list.Add(ins);
            }
            return list;
        }

        public static int UpdateInstructor(Instructor instructor)
        {
            
            string query = "UPDATE Instructors SET InstructorName = @InstructorName, Specialization = @Specialization, Email = @Email, Password = @Password WHERE InstructorID = @InstructorID";
            SqlParameter[] sp = {
                new SqlParameter("@InstructorID", instructor.InstructorID),
                new SqlParameter("@InstructorName", instructor.InstructorName),
                new SqlParameter("@Specialization", instructor.Specialization),
                new SqlParameter("@Email", instructor.Email),
                new SqlParameter("@Password", instructor.Password),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteInstructor(int instructorID)
        {
           
            string query = "DELETE FROM Instructors WHERE InstructorID = @InstructorID";
            SqlParameter[] sp =
            {
                new SqlParameter("@InstructorID", instructorID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

    }
}
