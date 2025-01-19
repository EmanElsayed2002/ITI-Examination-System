using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Data_Access_Layer
{
    public class DBManager
    {
        static SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI_db"].ConnectionString);

        public static DataTable ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            try
            {
                sql.Open();

                SqlCommand command = new SqlCommand(query, sql);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                result = command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query.", ex);
            }


            return result;
        }
        public static SqlDataAdapter GetDataAdapter(int examID)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();


            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Questions (QuestionText, QuestionType, ExamID, Option1Text, Option2Text, Option3Text, Option4Text, CorrectedAnswer) 
                VALUES (@QuestionText, @QuestionType, @ExamID, @Option1Text, @Option2Text, @Option3Text, @Option4Text, @CorrectedAnswer)",
                sql);
            insertCommand.Parameters.Add("@QuestionText", SqlDbType.NVarChar, 50, "Question");
            insertCommand.Parameters.Add("@QuestionType", SqlDbType.NVarChar, 6, "QuestionType");
            insertCommand.Parameters.AddWithValue("@ExamID", examID);
            insertCommand.Parameters.Add("@Option1Text", SqlDbType.NVarChar, 10, "option1");
            insertCommand.Parameters.Add("@Option2Text", SqlDbType.NVarChar, 10, "option2");
            insertCommand.Parameters.Add("@Option3Text", SqlDbType.NVarChar, 10, "option3");
            insertCommand.Parameters.Add("@Option4Text", SqlDbType.NVarChar, 10, "option4");
            insertCommand.Parameters.Add("@CorrectedAnswer", SqlDbType.NVarChar, 10, "Answer");


            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Questions 
                SET QuestionText = @QuestionText, 
                    QuestionType = @QuestionType, 
                    ExamID = @ExamID, 
                    Option1Text = @Option1Text, 
                    Option2Text = @Option2Text, 
                    Option3Text = @Option3Text, 
                    Option4Text = @Option4Text, 
                    CorrectedAnswer = @CorrectedAnswer 
                WHERE QuestionID = @QuestionID",
                sql);
            updateCommand.Parameters.Add("@QuestionID", SqlDbType.Int, 0, "QuestionID");
            updateCommand.Parameters.Add("@QuestionText", SqlDbType.NVarChar, 50, "Question");
            updateCommand.Parameters.Add("@QuestionType", SqlDbType.NVarChar, 50, "QuestionType");
            updateCommand.Parameters.AddWithValue("@ExamID", examID);
            updateCommand.Parameters.Add("@Option1Text", SqlDbType.NVarChar, 200, "option1");
            updateCommand.Parameters.Add("@Option2Text", SqlDbType.NVarChar, 200, "option2");
            updateCommand.Parameters.Add("@Option3Text", SqlDbType.NVarChar, 200, "option3");
            updateCommand.Parameters.Add("@Option4Text", SqlDbType.NVarChar, 200, "option4");
            updateCommand.Parameters.Add("@CorrectedAnswer", SqlDbType.NVarChar, 50, "Answer");


            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Questions WHERE QuestionID = @QuestionID",
                sql);
            deleteCommand.Parameters.Add("@QuestionID", SqlDbType.Int, 0, "QuestionID");

            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }



        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffetcted = -1;
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            try
            {
                if(sql.State == ConnectionState.Closed)
                sql.Open();
                
                rowsAffetcted = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if(sql.State != ConnectionState.Closed)
                sql.Close();
            }
            return rowsAffetcted;
        }

        public static DataTable ExecuteQueryList(string query , SqlParameter[] sp)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(sp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable  dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

    }
}
