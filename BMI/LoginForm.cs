using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

using System.Threading;

namespace BMI
{
    
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
        }


        Login login = new Login("admin", "1234");
        //go to login page
        HomeForm home_form = new HomeForm();
        MainForm main_form = new MainForm();
        Patient patient_form = new Patient();

        private void Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login2_Click_1(object sender, EventArgs e)
        {
            string user = nametxtbox.Text;
            string pass = pwdtxtbox.Text;
            //if (login.IsLoggedIn(user, pass))
            {
                this.Visible = false;
                
                //MessageBox.Show("Hello " + user + " " + pass, "Welcome");
                patient_form.ShowDialog();
            }
            //else
            {
                //show default login error message 
                //MessageBox.Show("Login Error!");
            }

        }

        private void Previous1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            
            main_form.ShowDialog();
        }
    }
}
