using Business_Logic_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class CreateExam : Form
    {
        int Id = 0;
        public Exam ExamDetails { get; set; } = new Exam();
        public CreateExam(int ID)
        {
            InitializeComponent();
            Id = ID;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            bool flag = false;
            if (string.IsNullOrEmpty(examName.Text.Trim()))
            {
                label11.Text = "please enter exam name";
                flag = true;
            }
            if (string.IsNullOrEmpty(examSubject.Text.Trim()))
            {
                label17.Text = "please enter subject name";
                flag = true;
            }
            if (string.IsNullOrEmpty(Durtaion.Text.Trim()))
            {
                label5.Text = "please enter Duration of Exam";
                flag = true;
            }


            if (!flag)
            {
                ExamDetails.InstructorID = Id;
                ExamDetails.ExamName = examName.Text;
                ExamDetails.Subject = examSubject.Text;
                ExamDetails.ExamDate = dateTimePicker1.Value;
                ExamDetails.Duration = Convert.ToInt32(Durtaion.Text);
                int examID = Business_Logic_Layer.EntityManager.ExamManager.AddExam(ExamDetails);
                //label7.Text = examID.ToString();
                if (examID > 0)
                {

                    MessageBox.Show("Exam added successfully!");
                    CreateQuestion question = new CreateQuestion(examID, Id);
                    question.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to add the exam.");
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            InstructorDashboard instructorDashboard = new InstructorDashboard(Id);
            instructorDashboard.Show();
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(Id);
            viewExams.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(Id);
            viewstudent.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(Id);
            createExam.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(Id);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(Id);
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
                this.Hide();
            }
            else
            {
                InstructorDashboard instructorDashboard = new InstructorDashboard(Id);
                instructorDashboard.Show();
                this.Hide();
            }
        }

        private void CreateExam_Load(object sender, EventArgs e)
        {
            
        }
    }
}
