using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            

            bool endProgram = false;


            do
            {
                try
                {
                    
                    StringBuilder resultString = new StringBuilder();

                    //Class to convert user input
                    InputConverter inputConverter = new InputConverter();

                    //Class to perform actual calculations
                    CalculatorUtil calculatorEngine = new CalculatorUtil();


                    Console.WriteLine("Enter first number");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    
                    Console.WriteLine("Enter second number");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Enter operator");
                    string operation = Console.ReadLine();



                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    //Change 2 - Iana 
                    //Formatting and displaying like that: The value 1 plus the value 2 is equal to 3.

                    string formatedResult = result.ToString("#.##");
                    string oper = CalculatorUtil.op;

                    resultString.AppendFormat("The value {0} {1} the value {2} is equal to {3}",
                                              firstNumber,
                                              oper,
                                              secondNumber,
                                              formatedResult);

                    Console.WriteLine(resultString);
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("If you want to exit the program type 'q' or 'Q'. Else, press ENTER.");
                string exitProgram = Console.ReadLine();

                if (exitProgram == "q" || exitProgram == "Q")
                {
                    endProgram = true;
                }
                else Console.WriteLine();
            }
            while (endProgram == false);



        }
    }
}