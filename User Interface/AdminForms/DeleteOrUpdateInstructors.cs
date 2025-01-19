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
    public partial class DeleteOrUpdateInstructors : Form
    {
        DataTable dt = new DataTable();
        int adminID;
        public DeleteOrUpdateInstructors(int id)
        {
            InitializeComponent();
            adminID = id;
        }

        private void DeleteOrUpdateInstructors_Load(object sender, EventArgs e)
        {
            dt = Business_Logic_Layer.EntitiyManager.AdminManager.GetAllInstructor();
            viewInstructors.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Business_Logic_Layer.EntityManager.InstructorManager.SyncInstructorData(dt);
                MessageBox.Show("Data Saved!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
