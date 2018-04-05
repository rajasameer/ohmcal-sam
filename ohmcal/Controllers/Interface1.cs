using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohmcal.Controllers
{
    public interface IOhmValueCalculator

    {

        /// <summary>

        /// Calculates the Ohm value of a resistor based on the band colors.

        /// <param name="bandAColor">The color of the first figure of component value band.</param>

        /// <param name="bandBColor">The color of the second significant figure band.</param>

        /// <param name="bandCColor">The color of the decimal multiplier band.</param>

        /// <param name="bandDColor">The color of the tolerance value band.</param>

        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

    }

    public class OhmValueCalculator : IOhmValueCalculator
    {
        string AColor;
        string BColor;
        string CColor;
        string DColor;

        public OhmValueCalculator()
        {
            AColor = " ";
            BColor = " ";
            CColor = " ";
            DColor = " ";

        }

        public OhmValueCalculator(string a, string b, string c, string d)
        {
            AColor = a;
            BColor = b;
            CColor = c;
            DColor = d;
        }
      
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {


            int a, b, c;
            double d;

            //adding dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Black", 0);
            dict.Add("Brown", 1);
            dict.Add("Red", 2);
            dict.Add("Orange", 3);
            dict.Add("Yellow", 4);
            dict.Add("Green", 5);
            dict.Add("Blue", 6);
            dict.Add("Violet", 7);
            dict.Add("Gray", 8);
            dict.Add("White", 9);

            //for tolerance
            Dictionary<string, double> Tol = new Dictionary<string, double>();
            Tol.Add("None", 20);
            Tol.Add("Brown", 1);
            Tol.Add("Red", 2);
            Tol.Add("Green", 0.5);
            Tol.Add("Blue", 0.25);
            Tol.Add("Violet", 0.1);
            Tol.Add("Gray", 0.05);
            Tol.Add("Gold", 5);
            Tol.Add("Silver", 10);
            
            a = dict[bandAColor];
            b = dict[bandBColor];
            c = dict[bandCColor];
            d = Tol[bandDColor];
            int p = (int)Math.Pow(10, c);

            return (a * 10 + b) * p;

           
        }





    }
    }

