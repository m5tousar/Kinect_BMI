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
    public partial class DataForm : Form
    {

        SavePatient save_patient = new SavePatient();
        NewPatient new_patient = new NewPatient();
        SavePatientInfo save_patient_info = new SavePatientInfo();
        BMI_Calculator calculate = new BMI_Calculator();
        SignUpForm sign_up = new SignUpForm();
        UserAccount user_acct = new UserAccount();
        LookUpPatient look_up_patient = new LookUpPatient();
        HomeForm home_front = new HomeForm();

        public String first_name;
        public String last_name;

        public DataForm()
        {
            InitializeComponent();

            if (look_up_patient.flag == 0)
            {
                user_first.Text = new_patient.User_first;
                user_last.Text = new_patient.User_last;
            }
            else
            {
                user_first.Text = look_up_patient.User_first;
                user_last.Text = look_up_patient.User_last;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeForm home_form = new HomeForm();
            home_form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main_form = new MainForm();
            main_form.ShowDialog();
        }



        

        private void calibrate_button_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            // Configure the process using the StartInfo properties.

            Process.Start("SkeletonColor.exe").WaitForExit();
            Process.Start("weightApp.exe").WaitForExit();
            Thread.Sleep(4000);
            
            process.Refresh();
            
            readHeight readH = new readHeight();
            readWeight readW = new readWeight();
            readWaist readWaist = new readWaist();

            //converting string (height and weight) to float
            float height = (float)Convert.ToDouble(readH.test());
            float weight = (float)Convert.ToDouble(readW.test());

            //converting float to string
            string height2 = Convert.ToString(height);
            string weight2 = Convert.ToString(weight);

            //BMI result function
            float result = calculate.calculator(height, weight);

            //convert the result to string 
            string result2 = Convert.ToString(result);

            //MessageBox.Show("Your BMI is: " + result, "BMI Result");
            user_height.Text = height2;
            user_weight.Text = weight2;
            bmi_result.Text = result2;
            user_waist.Text = readWaist.test();

            save_patient_info.save_patient(height2, weight2, result2);
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            home_front.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Configure the process using the StartInfo properties.
            this.Visible = false;
            home_front.ShowDialog();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {

        }

        /*  private void dbconnect()
          {
              string query = "";

              string dbconnectstring = "datasource=localhost;port=3306;username=root;password=;database=catapult;";
              MySqlConnection databaseConnection = new MySqlConnection(dbconnectstring);
              MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
              commandDatabase.CommandTimeout = 60;
              try
              {
                  databaseConnection.Open();
                  MySqlDataReader myreader = commandDatabase.ExecuteReader();
                  if (myreader.HasRows)
                  {
                      while (myreader.Read())
                      {
                          Console.WriteLine();
                      }
                  }
                  else
                  {
                      Console.WriteLine("cannot connect");
                  }
              }
          }
          */

    }
}
