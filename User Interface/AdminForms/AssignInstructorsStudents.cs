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
    public partial class AssignInstructorsStudents : Form
    {
        DataTable studentTable = new DataTable();
        DataTable instructorTable = new DataTable();
        int studentId = -1, instructirId = -1;
        int adminID;
        public AssignInstructorsStudents(int id)
        {
            InitializeComponent();
            adminID = id;
        }

        private void AssignInstructorsStudents_Load(object sender, EventArgs e)
        {
            studentTable = Business_Logic_Layer.EntityManager.InstructorManager.GetAllDataTable();
            instructorTable = Business_Logic_Layer.EntitiyManager.AdminManager.GetAllInstructor();
            cmbstudent.DataSource = studentTable;
            cmbstudent.DisplayMember = "StudentName";
            cmbstudent.ValueMember = "StudentID";
            cmbis.DataSource = instructorTable;
            cmbis.ValueMember = "InstructorID";
            cmbis.DisplayMember = "InstructorName";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (cmbstudent.SelectedValue != null)
            {
                studentId = Convert.ToInt32(cmbstudent.SelectedValue);
            }

            if (cmbis.SelectedValue != null)
            {
                instructirId = Convert.ToInt32(cmbis.SelectedValue);
            }


            if (cmbstudent.SelectedValue == null)
            {
                MessageBox.Show("Please Select student");
            }

            if (cmbis.SelectedValue == null)
            {
                MessageBox.Show("Please Select instructor");
            }

            if (studentId != -1 && instructirId != -1)
            {

                int rowsAffected = Business_Logic_Layer.EntitiyManager.AdminManager.assignInstructorStudent(studentId, instructirId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Assignment Done!!");
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
