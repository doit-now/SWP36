using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalculator
    {
        public static double GetBMI(double weight, double height) => weight / (height * height);

        public static string EvaluateBmiStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            if (bmi < 25)
                return "Perfect";
            if (bmi < 30)
                return "Overweight";
            return "Obese";
        }
    }
}
