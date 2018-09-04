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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        
        
        MainForm main_form = new MainForm();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LookUpPatient look_up_patient = new LookUpPatient();
            look_up_patient.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewPatient newPatient_form = new NewPatient();
            newPatient_form.ShowDialog();
        }

        private void Previous1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main_form.ShowDialog();
        }
    }
}
