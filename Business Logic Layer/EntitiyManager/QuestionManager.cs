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
            int rowsAffected = -1;
            string query = "INSERT INTO Questions (QuestionText, QuestionType, ExamID , Option1Text , Option2Text , Option3Text , Option4Text , CorrectedAnswer) VALUES (@QuestionText, @QuestionType, @ExamID , @opt1 , @opt2 , @opt3 ,@opt4 , @ans);SELECT SCOPE_IDENTITY();";
            SqlParameter[] sp ={
                new SqlParameter("@QuestionText", question.QuestionText),
                new SqlParameter("@QuestionType", question.QuestionType),
                new SqlParameter("@ExamID", question.ExamID),
                new SqlParameter("@opt1", question.OptionA),
                new SqlParameter("@opt2", question.OptionB),
                new SqlParameter("@opt3", question.OptionC),
                new SqlParameter("@opt4", question.OptionD),
                new SqlParameter("@ans", question.CorrectOption),
            };
             rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
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

        public static DataTable GetAllQuestions(int examID)
        {
            string query = "SELECT QuestionID, [QuestionText] as Question,[QuestionType] ,[Option1Text] as option1,[Option2Text] as option2 ,[Option3Text] as option3,[Option4Text] as option4,[CorrectedAnswer] as Answer FROM [Questions]   where ExamID = @ID ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID" , examID)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return dt;
        }

        //public static DataTable GridInsertUpdateDelete()
        //{
        //    string query = "insert into Questions(QuestionText , QuestionType , Option1Text , Option2Text ,Option3Text , Option4Text , CorrectedAnswer) values(@questionText , @questionType , @opt1  , @opt2 , @opt3 , @opt4 , @correctedAns)";
        //    SqlParameter[] sp = new SqlParameter[]
        //    {
        //        new SqlParameter("@ID" , examID)
        //    };
        //    DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
        //    return dt;
        //}
    }
}
