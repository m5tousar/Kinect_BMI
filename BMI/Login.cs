using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BMI
{
    class Login
    {

        public string user_name { get; set; }
        public string pass_word { get; set; }

        //initialize
        public Login(string user, string pass)
        {
            this.user_name = user;
            this.pass_word = pass;
        }
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        internal bool IsLoggedIn(string user, string pass)
        {
            //check if user name empty
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name");
                return false;
            }
            //check user name if valid type
            else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct
            else
            {
                if (user_name != user)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check if password is empty
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the Password");
                        return false;
                    }
                    //check if password is valid
                    else if (IntegerValidator(pass) == true)
                    {
                        MessageBox.Show("Enter only integer here");
                        return false;
                    }
                    //check if password is correct
                    else if (user_name != pass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }
        }
    }
}
