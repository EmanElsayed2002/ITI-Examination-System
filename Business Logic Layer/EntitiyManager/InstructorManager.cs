using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class InstructorManager
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
                    StudentName = dr["StudentName"]?.ToString(),
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
                new SqlParameter("@StudentID", student.StudentID),
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
        public static bool isInstructor(string email, string password)
        {
            string query = "select * from Instructors where email=@email and Password=password";
            SqlParameter[] sp =
            {
                new SqlParameter ("email", email),
                new SqlParameter ("password", password)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }


        public static DataTable viewAllExamCreatedByExam(int InsID)
        {
            string query = "SELECT ExamName , Subject , ExamDate FROM Instructors INNER JOIN Exams ON Exams.InstructorID = Instructors.InstructorID WHERE Instructors.InstructorID = @InsID";
            SqlParameter[] sp = {
                new SqlParameter ("@InsID" ,InsID)
            };
            return Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
        }

        public static int GetId(string email, string password)
        {
            string query = "select InstructorID from Instructors where email=@email and Password=@password";
            SqlParameter[] sp =
            {
                new SqlParameter ("email", email),
                new SqlParameter ("password", password)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);


            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>("InstructorID");
            }

            return -1;
        }

        public static DataTable ViewYourStudent(int ID)
        {
            string query = @"
            select S.StudentName ,S.Age , S.Email 
	        from Instructors I  inner JOIN 
            StudentInstructors S1 ON S1.InstructorID = I.InstructorID
	        join Students S on S.StudentID = S1.StudentID
	        where I.InstructorID = @ID
            ";
            SqlParameter[] sp = {
                new SqlParameter ("@ID",ID)
            };
            return Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
        }

        public static Instructor GetInstructor(int ID)
        {
            string query = "select * from Instructors where InstructorID = @ID";
            SqlParameter[] sp = {
                new SqlParameter ("@ID" , ID)
            };
            DataTable dt = new DataTable();
            dt = Data_Access_Layer.DBManager.ExecuteQuery (query, sp);
            Instructor s = new Instructor();
            if (dt.Rows.Count > 0)
            {
                s = new Instructor()
                {
                    InstructorID = Convert.ToInt32(dt.Rows[0]["InstructorID"]),
                    InstructorName = dt.Rows[0]["InstructorName"]?.ToString(),
                    Specialization = dt.Rows[0]["Specialization"]?.ToString(),
                    Email = dt.Rows[0]["Email"]?.ToString(),
                    Password = dt.Rows[0]["Password"]?.ToString(),
                };
            }
            return s;
        }

    }



}
