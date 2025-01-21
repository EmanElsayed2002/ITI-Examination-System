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
    public partial class ViewYourInstructors : Form
    {
        int StudentID;
        DataTable dt;
        public ViewYourInstructors(int ID)
        {
            InitializeComponent();
            StudentID = ID;
        }

        private void ViewYourInstructors_Load(object sender, EventArgs e)
        {
            dt = Business_Logic_Layer.EntityManager.StudentExamManager.viewYourInstructors(StudentID);
            dataGridInstructors.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourInstructors view = new ViewYourInstructors(StudentID);
            view.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(StudentID);
            studentDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewYourExams view = new viewYourExams(StudentID);
            view.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uncommingExams uncommingExams = new uncommingExams(StudentID);
            uncommingExams.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(StudentID);
            enterExam.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileStudent profileStudent = new ProfileStudent(StudentID);
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
