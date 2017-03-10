using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerAssignment6
{
    /// <summary>
    /// Business class
    /// </summary>
    class Business
    {
        /// <summary>
        /// Default constructor for business class
        /// </summary>
        public Business()
        {
        }

        /// <summary>
        /// Price calculations using for loop
        /// </summary>
        /// <param name="costIn"></param>
        /// <returns></returns>
        public string GetRetailPrices(decimal costIn) // decimal Cost In
        {
            string calculate = string.Empty;
            //For loop (repeating instruction) will go from 5% to 10% (falls out of the loop at 10% using < so that 11% is not reached) 
            for (int percent = 5; percent < 11; percent++)
            {
                decimal retailPrice = costIn + (costIn * (percent * .01m));
                calculate += string.Format("{0}% Markup: {1:C}\n", percent, retailPrice); //using C will set it to currency format
            }
            //Retuns to string the calculated value
            return calculate;
        }

    }
   
}
