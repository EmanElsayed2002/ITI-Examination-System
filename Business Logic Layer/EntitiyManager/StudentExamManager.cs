using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class StudentExamManager
    {
        public static int AddStudentExam(Result studentExam)
        {
            string query = "INSERT INTO StudentExams (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";
            SqlParameter[] sp ={
                new SqlParameter("@StudentID", studentExam.StudentID),
                new SqlParameter("@ExamID", studentExam.ExamID),
                new SqlParameter("@Score", studentExam.Score),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static List<Result> GetAllData()
        {
            string query = "SELECT * FROM StudentExams";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            List<Result> list = new List<Result>();
            foreach (DataRow dr in dt.Rows)
            {
                Result studentExam = new Result
                {
                    ResultID = Convert.ToInt32(dr["ResultID"]),
                    StudentID = Convert.ToInt32(dr["StudentID"]),
                    ExamID = Convert.ToInt32(dr["ExamID"]),
                    Score = Convert.ToInt32(dr["Score"])
                };
                list.Add(studentExam);
            }
            return list;
        }

        public static int UpdateStudentExam(Result studentExam)
        {
            string query = "UPDATE StudentExams SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE StudentExamID = @StudentExamID";
            SqlParameter[] sp = {
                new SqlParameter("@StudentExamID", studentExam.StudentID),
                new SqlParameter("@StudentID", studentExam.StudentID),
                new SqlParameter("@ExamID", studentExam.ExamID),
                new SqlParameter("@Score", studentExam.Score),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteStudentExam(int studentExamID)
        {
            string query = "DELETE FROM StudentExams WHERE StudentExamID = @StudentExamID";
            SqlParameter[] sp = {
                new SqlParameter("@StudentExamID", studentExamID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
    }
}
