using System;
using System.IO;
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
    public partial class LookUpPatient : Form
    {
        public LookUpPatient()
        {
            InitializeComponent();
        }


        Patient patient_form = new Patient();
        HomeForm home_form = new HomeForm();
        NewPatient new_patient = new NewPatient();

        public string first, last, fullName;
        private static string f_name;
        private static string l_name;
        private static int found;

        private void Previous1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            patient_form.ShowDialog();
            
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            first = user_first.Text;
            last = user_last.Text;
            f_name = first;
            l_name = last;
            fullName = last + first;
            
            string curFile = @"C:\Users\uta\Desktop\BMI\BMI\bin\Debug\Patients Data\" + fullName + ".txt";
            Console.WriteLine(fullName);
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

            if (File.Exists(curFile))
            {
                found = 1;
                MessageBox.Show("Patient: " + first + " " + last + " is found!", "Welcome");
                this.Visible = false;
                home_form.ShowDialog();
                
            }
            else
            {
                found = 0;
                MessageBox.Show("Patient has not been registered.", "Oops!");
                this.Visible = false;
                new_patient.ShowDialog();
            }

        }

        public string User_first
        {
            get { return f_name; }
            set { f_name = value; }
        }
        public string User_last
        {
            get { return l_name; }
            set { l_name = value; }
        }

        public int flag
        {
            get { return found; }
            set { found = value; }
        }


    }
}
