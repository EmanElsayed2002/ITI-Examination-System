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
    public partial class ViewYourStudent : Form
    {
        int ID;
        public ViewYourStudent(int _ID)
        {
            ID = _ID;
            InitializeComponent();
        }

        private void ViewYourStudent_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Business_Logic_Layer.EntityManager.InstructorManager.ViewYourStudent(ID);
            dataGridViewStudent.DataSource = dt;
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
    }
}
