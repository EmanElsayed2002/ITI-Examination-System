using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class StudentManager
    {
        public static int AddStudent(Student student)
        {
            string query = "INSERT INTO Students (StudentName, Email, Password, Age) VALUES (@StudentName, @Email, @Password, @Age)";
            SqlParameter[] sp ={
                new SqlParameter("@StudentName", student.StudentName),
                new SqlParameter("@Email", student.Email),
                new SqlParameter("@Password", student.Password),
                new SqlParameter("@Age", student.Age),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static List<Student> GetAllData()
        {
            string query = "SELECT * FROM Students";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                Student student = new Student
                {
                    StudentID = Convert.ToInt32(dr["StudentID"]),
                    StudentName = dr["StudentName"].ToString(),
                    Email = dr["Email"].ToString(),
                    Password = dr["Password"].ToString(),
                    Age = Convert.ToInt32(dr["Age"])
                };
                list.Add(student);
            }
            return list;
        }

        public static int UpdateStudent(Student student)
        {
            string query = "UPDATE Students SET StudentName = @StudentName, Email = @Email, Password = @Password, Age = @Age WHERE StudentID = @StudentID";
            SqlParameter[] sp = {
                //new SqlParameter("@StudentID", student.StudentID),
                new SqlParameter("@StudentName", student.StudentName),
                new SqlParameter("@Email", student.Email),
                new SqlParameter("@Password", student.Password),
                new SqlParameter("@Age", student.Age),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteStudent(int studentID)
        {
            string query = "DELETE FROM Students WHERE StudentID = @StudentID";
            SqlParameter[] sp = {
                new SqlParameter("@StudentID", studentID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
    }
}
