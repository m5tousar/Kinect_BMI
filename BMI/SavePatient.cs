using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BMI
{
    class SavePatient
    {
        public String first_name, last_name;

        public String read_name(String first, String last)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\uta\Desktop\BMI\BMI\bin\Debug\PatientNames.txt", true))
            {
                file.WriteLine(first + " " + last);
                this.first_name = first;
                this.last_name = last;
            }
            

            return first;
        }
        

    }
}
