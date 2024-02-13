using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemoPrateek
{
    public static class Triangle
    {  // Prateek Chadha lab3_ Mutant testing
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "This triangle is valid.";
            }
            else
            {
                result = "This triangle is NOT valid.";
            }
            return result;

        }
    }
}