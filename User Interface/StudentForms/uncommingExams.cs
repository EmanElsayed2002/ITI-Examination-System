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
    public partial class uncommingExams : Form
    {
        int ID;
        DataTable dt;
        public uncommingExams(int _ID)
        {
            InitializeComponent();
            ID = _ID;

        }

        private void uncommingExams_Load(object sender, EventArgs e)
        {
            dt = Business_Logic_Layer.EntityManager.StudentExamManager.UncommingExams(ID);
            dataGridIuncommingExams.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(ID);
            studentDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewYourExams view = new viewYourExams(ID);
            view.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourInstructors view = new ViewYourInstructors(ID);
            view.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uncommingExams uncommingExams = new uncommingExams(ID);
            uncommingExams.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(ID);
            enterExam.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileStudent profileStudent = new ProfileStudent(ID);
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
