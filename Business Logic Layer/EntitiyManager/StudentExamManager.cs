using Business_Logic_Layer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business_Logic_Layer.EntityManager
{
    public class StudentExamManager
    {
        public static DataTable GetStudentExams(int id)
        {
            string query = @"select e.ExamID , e.ExamName , e.Subject , e.Duration ,e.ExamDate , r.Score
            from Exams e join Results r
            on e.ExamID = r.ExamID
            join Students s on r.StudentID = s.StudentID
            where s.StudentID = @StudentID and e.ExamDate < getdate()
            ORDER BY 
            E.ExamDate ASC;";
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@StudentID" , id)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return dt;
        }

        public static List<Question> GetQuestion(int examId)
        {
            string querty = @"SELECT [QuestionID]
              ,[QuestionText]
              ,[QuestionType]
              ,[ExamID]
              ,[Option1Text]
              ,[Option2Text]
              ,[Option3Text]
              ,[Option4Text]
              ,[CorrectedAnswer]
          FROM [ITIExaminationSystem].[dbo].[Questions]
          where [ExamID] = @ID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID" , examId)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQueryList(querty, sp);
            List<Question> Questions = new List<Question>();
            foreach (DataRow dr in dt.Rows)
            {
                Question question = new Question()
                {
                    QuestionID = Convert.ToInt32(dr["QuestionID"]),
                    QuestionText = dr["QuestionText"].ToString(),
                    QuestionType = dr["QuestionType"].ToString(),
                    //ExamID = Convert.ToInt32("ExamID"),
                    OptionA = dr["Option1Text"].ToString(),
                    OptionB = dr["Option2Text"].ToString(),
                    OptionC = dr["Option3Text"].ToString(),
                    OptionD = dr["Option4Text"].ToString(),
                    CorrectOption = dr["CorrectedAnswer"].ToString()
                };
                Questions.Add(question);
            }
            return Questions;
        }


        public static DataTable viewYourInstructors(int id)
        {
            string query = @"
                select I.InstructorName , I.Specialization , I.Email
	            from Instructors I join StudentInstructors SI
	            on I.InstructorID= SI.InstructorID
	            join Students S
	            on S.StudentID = SI.StudentID
	            where S.StudentID = @ID";
            SqlParameter[] sp = new SqlParameter[] {
             new SqlParameter("@ID" , id)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return dt;
        }

        public static DataTable UncommingExams(int id)
        {
            string query = @"
            SELECT 
                E.ExamName, 
                E.Subject, 
                E.ExamDate, 
                E.Duration,
                I.InstructorName
            FROM 
                Students S
            INNER JOIN 
                StudentInstructors SI ON S.StudentID = SI.StudentID
            INNER JOIN 
                Instructors I ON SI.InstructorID = I.InstructorID
            INNER JOIN 
                Exams E ON I.InstructorID = E.InstructorID
            WHERE 
                E.ExamDate > GETDATE() and S.StudentID = @ID
            ORDER BY 
                S.StudentID, 
                E.ExamDate ASC;
            ";
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@ID" , id)
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return dt;

        }
        public static int GetStudentusnigEP(string email , string password)
        {
            string query = "select StudentID from Students where email = @email and password = @password";
            SqlParameter[] sp = {
                new SqlParameter ("@email" , email),
                new SqlParameter ("@password" , password)
            };
            DataTable dt = new DataTable();
            dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return Convert.ToInt32(dt.Rows[0]["StudentID"]);
        }
        public static Student GetStudent(int id)
        {
            string query = "select * from Students where StudentID = @ID";
            SqlParameter[] sp = {
                new SqlParameter ("@ID" , id)
            };
            DataTable dt = new DataTable();
            dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            Student s = new Student();
            if (dt.Rows.Count > 0)
            {
                s = new Student()
                {
                    StudentID = Convert.ToInt32(dt.Rows[0]["StudentID"]),
                    StudentName = dt.Rows[0]["StudentName"]?.ToString(),
                    Age = Convert.ToInt32(dt.Rows[0]["Age"]),
                    Email = dt.Rows[0]["Email"]?.ToString(),
                    Password = dt.Rows[0]["Password"]?.ToString(),
                };
            }
            return s;
        }

        public static DataTable GetCurrectExamFroStudent(int ID)
        {
            string query = @"
            SELECT 
                E.ExamName, 
                E.Subject, 
                E.ExamDate, 
                E.Duration,
                I.InstructorName,
                E.ExamID
            FROM 
                Students S
            INNER JOIN 
                StudentInstructors SI ON S.StudentID = SI.StudentID
            INNER JOIN 
                Instructors I ON SI.InstructorID = I.InstructorID
            INNER JOIN 
                Exams E ON I.InstructorID = E.InstructorID
            WHERE 
                E.ExamDate = GETDATE() and S.StudentID = @ID
            ORDER BY 
                S.StudentID, 
                E.ExamDate ASC;
            ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID" , ID)
            };
            DataTable dt = new DataTable();
            dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            return dt;
        }

        public static bool CheckAnswer(int QuestionID, string Answer)
        {
            var query = @"SELECT
                  [CorrectedAnswer]
              FROM [ITIExaminationSystem].[dbo].[Questions]
              where QuestionID = @QuestionID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@QuestionID" , QuestionID),
            };
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query, sp);
            string CorrectedAns = dt.Rows[0]["CorrectedAnswer"].ToString();
            return CorrectedAns == Answer;
        }
        public static void SetSore(int studentID  ,int examID)
        {
            var query = "insert into results values(@StudentID , @InstructorID , @ExamID)";
            SqlParameter[] sp = new SqlParameter[]{
            new SqlParameter("@StudentID" , studentID),
            new SqlParameter("@InstructorID" , studentID),
            new SqlParameter("@ExamID" , studentID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            if (rowsAffected > 0)
            {

            }
            else
            {
                throw new Exception();
            }
        }

    }
}
