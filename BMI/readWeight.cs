using System;
using System.IO;
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
    class readWeight
    {
        String weight;

        public String test()
        {
            try
            {
                using (StreamReader sr = new StreamReader("weight1.txt"))
                {
                    String line = sr.ReadToEnd();
                    this.weight = line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return weight;
        }
    }
}
