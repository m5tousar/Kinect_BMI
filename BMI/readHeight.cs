﻿using System;
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
    class readHeight
    {
        String height;

        public String test()
        {
            try
            {
                string line = File.ReadLines("TotalHeight.txt").Skip(0).Take(1).First();
                this.height = line;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return height;
        }
    }
}
