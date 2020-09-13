using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculatorUtil
    {
        public static string op;

        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //change 1 - Adam
            //checks if the operation is a correct operation and if not, ask the user to enter again
            double result;
            string[] checkString = { "add", "+", "substract", "-", "multiply", "*", "divide", "/", "exponent", "^" };

            if (checkString.Contains(argOperation))
            { 
                switch (argOperation.ToLower())
                {
                    case "add":
                    case "+":
                        result = argFirstNumber + argSecondNumber;
                        op = "plus";
                        break;
                    case "subtract":
                    case "-":
                        result = argFirstNumber - argSecondNumber;
                        op = "minus";
                        break;
                    case "multiply":
                    case "*":
                        result = argFirstNumber * argSecondNumber;
                        op = "multiplied by";
                        break;
                    case "divide":
                    case "/":
                        result = argFirstNumber / argSecondNumber;
                        op = "divided by";
                        break;
                    case "^": //Change 4 - Adam
                    case "exponent": //adds the to the power of component to the calculator
                        result = Math.Pow(argFirstNumber, argSecondNumber);
                        op = "raised by";
                        break;
                    default:
                        throw new InvalidOperationException("Specified operation is not recognized.");
                }
                return result;
            }
            else
            {
                Console.WriteLine("Please enter '+' or 'add' to indicate your operation");
                Console.WriteLine("(ex: +, add, -, minus, *, multiply, /, divide, ^, exponent)");
                return Calculate(Console.ReadLine(), argFirstNumber, argSecondNumber);
            }
        }
    }
}
