using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace BMI
{
    public partial class HomeForm : Form
    {
        public String first_name;
        public String last_name;
        public String full_name;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPatient new_patient = new NewPatient();
            this.first_name = new_patient.User_first;
            this.last_name = new_patient.User_last;
            Console.WriteLine(full_name);
            Process.Start(@"C:\Users\uta\Desktop\BMI\BMI\bin\Debug\Patients Data\" + full_name + ".txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main_form = new MainForm();
            main_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DataForm data_form = new DataForm();
            data_form.ShowDialog();
        }
    }
}
