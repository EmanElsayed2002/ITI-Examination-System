using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class ExamManager
    {
        public static int AddExam(Exam exam)
        {
            string query = "INSERT INTO Exams (ExamName, Subject, ExamDate, InstructorID) VALUES (@ExamName, @Subject, @Date, @InstructorID)";
            SqlParameter[] sp ={
                new SqlParameter("@ExamName", exam.ExamName),
                new SqlParameter("@Subject", exam.Subject),
                new SqlParameter("@Date", exam.ExamDate),
                new SqlParameter("@InstructorID", exam.InstructorID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static List<Exam> GetAllData()
        {
            string query = "SELECT * FROM Exams";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            List<Exam> list = new List<Exam>();
            foreach (DataRow dr in dt.Rows)
            {
                Exam exam = new Exam
                {
                    ExamID = Convert.ToInt32(dr["ExamID"]),
                    ExamName = dr["ExamName"].ToString(),
                    Subject = dr["Subject"].ToString(),
                    ExamDate = Convert.ToDateTime(dr["ExamDate"]),
                    InstructorID = Convert.ToInt32(dr["InstructorID"])
                };
                list.Add(exam);
            }
            return list;
        }

        public static int UpdateExam(Exam exam)
        {
            string query = "UPDATE Exams SET ExamName = @ExamName, Subject = @Subject, ExamDate = @Date, InstructorID = @InstructorID WHERE ExamID = @ExamID";
            SqlParameter[] sp = {
                new SqlParameter("@ExamID", exam.ExamID),
                new SqlParameter("@ExamName", exam.ExamName),
                new SqlParameter("@Subject", exam.Subject),
                new SqlParameter("@Date", exam.ExamDate),
                new SqlParameter("@InstructorID", exam.InstructorID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteExam(int examID)
        {
            string query = "DELETE FROM Exams WHERE ExamID = @ExamID";
            SqlParameter[] sp = {
                new SqlParameter("@ExamID", examID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
    }
}
