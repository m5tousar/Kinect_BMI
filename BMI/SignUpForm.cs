using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class SignUpForm : Form
    {
        public string userFirst;
        public string userLast;

        UserAccount user_acct = new UserAccount();
        HomeForm home_form = new HomeForm();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Previous1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main_form = new MainForm();
            main_form.ShowDialog();
        }

        private void Login2_Click(object sender, EventArgs e)
        {
            userFirst = user_first.Text;
            userLast = user_last.Text;

            //user_acct.person(userFirst, userLast);
            user_acct.firstname(userFirst);
            user_acct.lastname(userLast);


            this.Visible = false;
            
            MessageBox.Show("Hello " + user_acct.user_first + " " + user_acct.user_last, "Welcome");
            home_form.ShowDialog();
        }
    }
}
