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
            int newExamID = -1;
            string query = @"
        INSERT INTO Exams (ExamName, Subject, ExamDate, InstructorID, Duration) 
        VALUES (@ExamName, @Subject, @Date, @InstructorID, @Duration);
        SELECT SCOPE_IDENTITY();";

            SqlParameter[] sp = {
        new SqlParameter("@ExamName", exam.ExamName),
        new SqlParameter("@Subject", exam.Subject),
        new SqlParameter("@Date", exam.ExamDate),
        new SqlParameter("@InstructorID", exam.InstructorID),
        new SqlParameter("@Duration", exam.Duration),
    };

            object result = Data_Access_Layer.DBManager.ExecuteScalar(query, sp);

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                newExamID = id;
            }

            return newExamID;
        }


        public static Exam GetAllDataUsingID(int ID)
        {
            string query = "SELECT * FROM Exams where ExamID = @ID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID" ,ID)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query , sp);
            Exam ExamDetails = new Exam();
            if (dt.Rows.Count > 0)
            {
                ExamDetails = new Exam()
                {
                    ExamID = Convert.ToInt32(dt.Rows[0]["ExamID"]),
                    ExamName = dt.Rows[0]["ExamName"].ToString(),
                    Subject = dt.Rows[0]["Subject"].ToString(),
                    Duration = dt.Rows[0]["Duration"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["Duration"]) : 2,
                    ExamDate = Convert.ToDateTime(dt.Rows[0]["ExamDate"]),
                    InstructorID = Convert.ToInt32(dt.Rows[0]["InstructorID"])
                };
                
            }
            return ExamDetails;
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

        public static DataTable selectAllExamsRelatedToInstructor(int InstrutorID)
        {
            string query = "select ExamID, ExamName , Subject,ExamDate from Exams where InstructorID = @ID";
            SqlParameter[] sp = {
                new SqlParameter("@ID" , InstrutorID)
            };
            return Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
        }


        public static void SyncData(DataTable dt, int examID)
        {
            SqlDataAdapter adapter = Data_Access_Layer.DBManager.GetDataAdapter(examID);

            try
            {
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error syncing data: " + ex.Message);
            }
        }


    }
}
