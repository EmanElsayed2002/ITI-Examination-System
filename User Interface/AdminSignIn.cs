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
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(adminEmail.Text.Trim()) || string.IsNullOrEmpty(AdminPass.Text.Trim())){

            }
        }
        
       
    }
}
