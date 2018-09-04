using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class BMI_Calculator
    {
        //public string weight;
        //public string height;


        public float calculator (float height, float weight)
        {
            float bmi;

            bmi =((weight * 703) / (height * height));
            return bmi;
        }

    }
}
