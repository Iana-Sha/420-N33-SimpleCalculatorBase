using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public static string op;
        
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            

            switch(argOperation.ToLower())
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
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }
    }
}
