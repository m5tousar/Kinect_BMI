using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class SavePatientInfo
    {
        NewPatient new_patient = new NewPatient();

        public String user_height, user_weight, user_bmi;
        public string user_first, user_last, full_name;

        public String save_patient(String height, String weight, String bmi)
        {
            user_first = new_patient.User_first;
            user_last = new_patient.User_last;
            this.full_name = user_last + user_first;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\uta\Desktop\BMI\BMI\bin\Debug\Patients Data\" + full_name+".txt", true))
            {
                String date = String.Format("{0}", DateTime.Now);
                file.WriteLine("Height: " + height + " ,Weight: " + weight + " ,BMI: " + bmi + ", DATE: " + date);
                this.user_height = height;
                this.user_weight = weight;
                this.user_bmi = bmi;
            }


            return height;
        }
    }
}
