using Business_Logic_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.StudentForms
{
    public partial class ExamWindow : Form
    {
        Question currentQuestion;
        int ID;
        int idx = 0;
        int Score = 0;
        List<Question> Questions;
        Exam ExamDetails;
        int elapsedSeconds = 0;
        int examDurationseconds = 0, passingScore = 0;
        int studentId = -1;
        public ExamWindow(int examId, int studentID)
        {
            InitializeComponent();
            ID = examId;
            studentId = studentID;

        }

        private void ExamWindow_Load(object sender, EventArgs e)
        {

            ExamDetails = Business_Logic_Layer.EntityManager.ExamManager.GetAllDataUsingID(ID);
            Questions = Business_Logic_Layer.EntityManager.StudentExamManager.GetQuestion(ID);
            //lblTimer.Text = $"{examDuration}";
            passingScore = Questions.Count / 2;
            noOfQuestions.Text = $"{idx + 1}/{Questions.Count}";
            if (ExamDetails != null)
            {
                examID.Text = ExamDetails.ExamID.ToString();
                examName.Text = ExamDetails.ExamName.ToString();
                examSubject.Text = ExamDetails.Subject.ToString();
                examDurationTextBox.Text = ExamDetails.Duration.ToString();
                examDate.Text = ExamDetails.ExamDate.ToString();
            }
            if (Questions.Count > 0)
            {
                examDurationseconds = ExamDetails.Duration * 3600;
                timer1.Start();
                ShowQuestion(idx);
            }
            else
            {
                MessageBox.Show("No questions found for this exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void ShowQuestion(int index)
        {
            currentQuestion = Questions[index];
            if (currentQuestion.QuestionType == "MCQ")
            {
                labelquestionText.Text = currentQuestion.QuestionText;
                op1.Text = currentQuestion.OptionA;
                op2.Text = currentQuestion.OptionB;
                op3.Text = currentQuestion.OptionC;
                op4.Text = currentQuestion.OptionD;
            }
            else
            {
                labelquestionText.Text = currentQuestion.QuestionText;
                op1.Text = currentQuestion.OptionA;
                op2.Text = currentQuestion.OptionB;
                op3.Visible = false;
                op4.Visible = false;

            }

            op1.Checked = false;
            op2.Checked = false;
            op3.Checked = false;
            op4.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            SaveAnswer();
            if (idx < Questions.Count - 1)
            {
                idx++;
                noOfQuestions.Text = $"{idx + 1}/{Questions.Count}";

                ShowQuestion(idx);
            }
            else
            {
                string resultMessage = Score >= passingScore ?
                    $"Congratulations!\n\nYou have completed the exam!\nYour final score is: {Score}.\n\nGreat job!" :
                    $"The exam is over.\n\nYour final score is: {Score}.\n\nDon't worry, keep trying!";

                MessageBox.Show(resultMessage,
                    Score >= passingScore ? "Exam Completed" : "Exam Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Business_Logic_Layer.EntityManager.StudentExamManager.SetSore(studentId, currentQuestion.ExamID);
                //EndExam();
            }
        }
        private void SaveAnswer()
        {
            var selectedOption = "";

            if (op1.Checked) selectedOption = op1.Text;
            else if (op2.Checked) selectedOption = op2.Text;
            else if (op3.Checked) selectedOption = op3.Text;
            else if (op4.Checked) selectedOption = op4.Text;

            if (Business_Logic_Layer.EntityManager.StudentExamManager.CheckAnswer(Questions[idx].QuestionID, selectedOption))
                Score++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            TimeSpan remainingTime = TimeSpan.FromSeconds(examDurationseconds - elapsedSeconds);
            lblTimer.Text = $"Time Remaining: {remainingTime:mm\\:ss}";

            if (elapsedSeconds >= examDurationseconds)
            {
                timer1.Stop();
                MessageBox.Show("Time is up! The exam will now end.", "Exam Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EndExam();
            }
        }
        private void EndExam()
        {
            SaveAnswer();

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(studentId);
            studentDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewYourExams view = new viewYourExams(studentId);
            view.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourInstructors view = new ViewYourInstructors(studentId);
            view.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uncommingExams uncommingExams = new uncommingExams(studentId);
            uncommingExams.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(studentId);
            enterExam.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileStudent profileStudent = new ProfileStudent(studentId);
            profileStudent.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
    }
}
