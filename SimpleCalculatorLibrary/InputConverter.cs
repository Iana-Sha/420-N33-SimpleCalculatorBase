using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            //Change 1 - Adam
            //do while loop to ask for the number again if the String entered isn't a number
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber))
                do
                {
                    if (double.TryParse(argTextInput, out convertedNumber))
                        break;
                    else
                    {
                        Console.WriteLine("Please enter a numerical value (ex: 0-9)");
                        return ConvertInputToNumeric(Console.ReadLine());
                    }

                } while (!double.TryParse(argTextInput, out convertedNumber));
            return convertedNumber;
        }
    }
}
