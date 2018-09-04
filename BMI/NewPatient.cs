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
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private static string f_name;
        private static string l_name;
        private static int found;

        Patient patient_form = new Patient();
        HomeForm home_form = new HomeForm();

        private void Previous1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            patient_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavePatient save_Patient = new SavePatient();
            DataForm data_form = new DataForm();

            string first = user_first.Text;
            string last = user_last.Text;
            

            f_name = first;
            l_name = last;

            save_Patient.read_name(first, last);
            

            this.Visible = false;
            home_form.ShowDialog();

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
