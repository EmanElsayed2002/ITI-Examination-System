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
    public partial class InstructorDashboard : Form
    {
        //Form1 form = new Form1();
        int ID = 0;
        public InstructorDashboard(int _ID)
        {
            InitializeComponent();
            ID = _ID;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(ID);
            viewExams.Show();
            this.Hide();
        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(ID);
            viewstudent.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(ID);
            createExam.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(ID);
            profile.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(ID);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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
                InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
                instructorDashboard.Show();
                this.Hide();
            }
        }
    }
}
