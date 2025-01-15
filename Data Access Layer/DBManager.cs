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
             SqlCommand cmd = new SqlCommand(query , sql);
             DataTable dt = new DataTable();
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             adapter.Fill(dt);
             return dt;
        }

        public static DataTable ExecuteQuery(string query , SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }



        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffetcted = -1;
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            try
            {
                sql.Open();
                rowsAffetcted = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                sql.Close();
            }
            return rowsAffetcted;
        }

    }
}
