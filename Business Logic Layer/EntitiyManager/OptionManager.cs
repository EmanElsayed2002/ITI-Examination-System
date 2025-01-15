using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class OptionManager
    {
        public static int AddOption(Option option)
        {
            string query = "INSERT INTO Options (OptionText, QuestionID, IsCorrect) VALUES (@OptionText, @QuestionID, @IsCorrect)";
            SqlParameter[] sp ={
                new SqlParameter("@OptionText", option.OptionText),
                new SqlParameter("@QuestionID", option.QuestionID),
                new SqlParameter("@IsCorrect", option.IsCorrect)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static List<Option> GetAllData()
        {
            string query = "SELECT * FROM Options";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            List<Option> list = new List<Option>();
            foreach (DataRow dr in dt.Rows)
            {
                Option option = new Option
                {
                    OptionID = Convert.ToInt32(dr["OptionID"]),
                    OptionText = dr["OptionText"].ToString(),
                    QuestionID = Convert.ToInt32(dr["QuestionID"]),
                    IsCorrect = Convert.ToBoolean(dr["IsCorrect"])
                };
                list.Add(option);
            }
            return list;
        }

        public static List<Option> GetOptionsByQuestionID(int questionID)
        {
            string query = "SELECT * FROM Options WHERE QuestionID = @QuestionID";
            SqlParameter[] sp = {
                new SqlParameter("@QuestionID", questionID)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            List<Option> list = new List<Option>();
            foreach (DataRow dr in dt.Rows)
            {
                Option option = new Option
                {
                    OptionID = Convert.ToInt32(dr["OptionID"]),
                    OptionText = dr["OptionText"].ToString(),
                    QuestionID = Convert.ToInt32(dr["QuestionID"]),
                    IsCorrect = Convert.ToBoolean(dr["IsCorrect"])
                };
                list.Add(option);
            }
            return list;
        }

        public static int UpdateOption(Option option)
        {
            string query = "UPDATE Options SET OptionText = @OptionText, QuestionID = @QuestionID, IsCorrect = @IsCorrect WHERE OptionID = @OptionID";
            SqlParameter[] sp = {
                new SqlParameter("@OptionID", option.OptionID),
                new SqlParameter("@OptionText", option.OptionText),
                new SqlParameter("@QuestionID", option.QuestionID),
                new SqlParameter("@IsCorrect", option.IsCorrect)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int DeleteOption(int optionID)
        {
            string query = "DELETE FROM Options WHERE OptionID = @OptionID";
            SqlParameter[] sp = {
                new SqlParameter("@OptionID", optionID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
    }
}
