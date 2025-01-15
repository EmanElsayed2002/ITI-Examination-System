using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class QuestionManager
    {
        public static int AddQuestion(Question question)
        {
            string query = "INSERT INTO Questions (QuestionText, QuestionType, ExamID, CorrectOption) VALUES (@QuestionText, @QuestionType, @ExamID, @CorrectAnswer)";
            SqlParameter[] sp ={
                new SqlParameter("@QuestionText", question.QuestionText),
                new SqlParameter("@QuestionType", question.QuestionType),
                new SqlParameter("@ExamID", question.ExamID),
                new SqlParameter("@CorrectAnswer", question.CorrectOption),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static List<Question> GetAllData()
        {
            string query = "SELECT * FROM Questions";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            List<Question> list = new List<Question>();
            foreach (DataRow dr in dt.Rows)
            {
                Question question = new Question
                {
                    QuestionID = Convert.ToInt32(dr["QuestionID"]),
                    QuestionText = dr["QuestionText"].ToString(),
                    QuestionType = dr["QuestionType"].ToString(),
                    ExamID = Convert.ToInt32(dr["ExamID"]),
                    CorrectOption = dr["CorrectAnswer"].ToString()
                };
                list.Add(question);
            }
            return list;
        }

        public static int UpdateQuestion(Question question)
        {
            string query = "UPDATE Questions SET QuestionText = @QuestionText, QuestionType = @QuestionType, ExamID = @ExamID, CorrectAnswer = @CorrectAnswer WHERE QuestionID = @QuestionID";
            SqlParameter[] sp = {
                new SqlParameter("@QuestionID", question.QuestionID),
                new SqlParameter("@QuestionText", question.QuestionText),
                new SqlParameter("@QuestionType", question.QuestionType),
                new SqlParameter("@ExamID", question.ExamID),
                new SqlParameter("@CorrectAnswer", question.CorrectOption),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteQuestion(int questionID)
        {
            string query = "DELETE FROM Questions WHERE QuestionID = @QuestionID";
            SqlParameter[] sp = {
                new SqlParameter("@QuestionID", questionID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
    }
}
