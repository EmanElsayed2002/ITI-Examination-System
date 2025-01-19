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

namespace User_Interface
{
    public partial class CreateQuestion : Form
    {
        string? selectedItem = "MCQ";
        int QuestionID;
        public Question QuestionDetails { get; set; } = new Question();
        public Option QuestionOptions { get; set; }
        int ID;
        public CreateQuestion(int examID, int instrID)
        {
            InitializeComponent();
            QuestionDetails.ExamID = examID;

            ID = instrID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            comboBoxQuestionType.Items.Add("MCQ");
            comboBoxQuestionType.Items.Add("True$False");
            //label2.Text = QuestionDetails.ExamID.ToString();
            //selectedItem = comboBoxQuestionType.SelectedItem?.ToString();
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxQuestionType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedItem = comboBoxQuestionType.SelectedItem?.ToString();
            if (selectedItem == "MCQ")
            {
                Opt3.Visible = true;
                Opt4.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                Opt3.Visible = false;
                Opt4.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            if (selectedItem == null)
            {
                flag = true;
                labelTypeOfQuestion.Text = "please choose type of your Question";
            }
            if (string.IsNullOrEmpty(QuestionBody.Text.Trim()))
            {
                flag = true;
                label15.Text = "please enter your Question";
            }
            if (string.IsNullOrEmpty(Opt1.Text.Trim()))
            {
                flag = true;
                label10.Text = "please enter option1";
            }
            if (string.IsNullOrEmpty(Opt2.Text.Trim()))
            {
                flag = true;
                lblOp2.Text = "please enter option2 ";
            }
            if (string.IsNullOrEmpty(Answer.Text.Trim()))
            {
                flag = true;
                lblAnswer.Text = "please enter Answer";
            }

            if (flag == false)
            {
                QuestionDetails.QuestionText = QuestionBody.Text;
                QuestionDetails.QuestionType = selectedItem;


                QuestionDetails.OptionA = Opt1.Text.ToString();

                QuestionDetails.OptionB = Opt2.Text.ToString();

                QuestionDetails.OptionC = Opt3.Text.ToString();

                QuestionDetails.OptionD = Opt4.Text.ToString();

                QuestionDetails.CorrectOption = Answer.Text;
                QuestionID = Business_Logic_Layer.EntityManager.QuestionManager.AddQuestion(QuestionDetails);
                if (QuestionID > 0)
                {
                    clearFieldandLabels();
                    MessageBox.Show("Question and options added successfully!");

                }
                else
                {
                    MessageBox.Show("Other question types can be handled here.");
                }
            }
            else
            {
                MessageBox.Show("Error try Again!!");
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("would you like to make another exam?", "confirm", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                CreateExam createExam = new CreateExam(QuestionDetails.ExamID);
                createExam.Show();
                this.Hide();
            }
            else
            {
                InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
                instructorDashboard.Show();
                this.Hide();
            }


        }
        public void clearFieldandLabels()
        {
            comboBoxQuestionType.SelectedIndex = -1; 
            QuestionBody.Text = string.Empty;
            Opt1.Text = string.Empty;
            Opt2.Text = string.Empty;
            Opt3.Text = string.Empty;
            Opt4.Text = string.Empty;
            Answer.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(ID);
            viewExams.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(ID);
            viewstudent.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(ID);
            createExam.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(ID);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(ID);
            profile.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("would you like to Logout?", "confirm", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Form1 frm = new Form1();
                frm.Show();
                frm.Hide();
            }
            else
            {
                InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
                instructorDashboard.Show();
                this.Hide();
            }
        }
    }
}
