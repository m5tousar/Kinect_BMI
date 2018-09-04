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
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void Previous1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main_form = new MainForm();
            main_form.ShowDialog();
        }
    }
}
