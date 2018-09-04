using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Patient patient_form = new Patient();
            patient_form.ShowDialog();
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            AboutForm about_form = new AboutForm();
            about_form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InstructionsForm instructions_form = new InstructionsForm();
            instructions_form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
