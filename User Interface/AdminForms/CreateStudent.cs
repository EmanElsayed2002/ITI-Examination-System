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

namespace User_Interface.AdminForms
{
    public partial class CreateStudent : Form
    {
        int adminID;
        public Student StudentDetails { get; set; } = new Student();
        public CreateStudent(int id)
        {
            InitializeComponent();
            adminID = id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentName.Text.Trim())
               || string.IsNullOrEmpty(age.Text.Trim()) ||
               string.IsNullOrEmpty(email.Text.Trim())
               ||
                   string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Complete All Fields");
            }
            else
            {
                StudentDetails.StudentName = studentName.Text;
                StudentDetails.Age = Convert.ToInt32(age.Text);
                StudentDetails.Email = email.Text;
                StudentDetails.Password = password.Text;
                int RowsAffected = Business_Logic_Layer.EntityManager.InstructorManager.AddStudent(StudentDetails);
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Student Inserted Successfully!");
                    studentName.Text = "";
                    age.Text = "";
                    email.Text = "";
                    password.Text = "";
                }
                else
                {
                    MessageBox.Show("Erorrrrr");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(adminID);
            adminDashboard.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateInstructor createInstructor = new CreateInstructor(adminID);
            createInstructor.Show();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminViewInstructors adminViewInstructors = new AdminViewInstructors(adminID);
            adminViewInstructors.Show();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteOrUpdateInstructors deleteOrUpdateInstructors = new DeleteOrUpdateInstructors(adminID);
            deleteOrUpdateInstructors.Show();
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AssignInstructorsStudents assignInstructorsStudents = new AssignInstructorsStudents(adminID);
            assignInstructorsStudents.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminViewStudents adminViewStudents = new AdminViewStudents(adminID);
            adminViewStudents.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStudent createStudent = new CreateStudent(adminID);
            createStudent.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUpdateStudent deleteUpdateStudent = new DeleteUpdateStudent(adminID);
            deleteUpdateStudent.Show();
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DeleteUpdateStudent deleteUpdateStudent = new DeleteUpdateStudent(adminID);
            deleteUpdateStudent.Show();
            Close();
        }
    }
}
