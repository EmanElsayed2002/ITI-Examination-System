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
    public partial class ProfileStudent : Form
    {
        public Student StudentDetails { get; set; } = new Student();
        public ProfileStudent(int id)
        {
            InitializeComponent();
            StudentDetails.StudentID = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileStudent_Load(object sender, EventArgs e)
        {
            try
            {
                StudentDetails = Business_Logic_Layer.EntityManager.StudentExamManager.GetStudent(StudentDetails.StudentID);
                if (StudentDetails != null)
                {
                    studentName.Text = StudentDetails.StudentName;
                    age.Text = StudentDetails.Age.ToString();
                    password.Text = StudentDetails.Password;
                    email.Text = StudentDetails.Email;
                }
                else
                {
                    MessageBox.Show("Failed to load instructor details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentName.Text.Trim()) ||
                string.IsNullOrEmpty(age.Text.Trim()) ||
                string.IsNullOrEmpty(email.Text.Trim()) ||
                string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please Fill all Fields", "error", MessageBoxButtons.OK);
            }
            else
            {
                StudentDetails.StudentName = studentName.Text;
                StudentDetails.Email = email.Text;
                StudentDetails.Age = Convert.ToInt32(age.Text);
                StudentDetails.Password = password.Text;
                int rowsAffected = Business_Logic_Layer.EntityManager.InstructorManager.UpdateStudent(StudentDetails);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your profile is Updated", "Confirm", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error Try Again Later!!", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(StudentDetails.StudentID);
            studentDashboard.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourInstructors view = new ViewYourInstructors(StudentDetails.StudentID);
            view.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uncommingExams uncommingExams = new uncommingExams(StudentDetails.StudentID);
            uncommingExams.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(StudentDetails.StudentID);
            enterExam.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileStudent profileStudent = new ProfileStudent(StudentDetails.StudentID);
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
