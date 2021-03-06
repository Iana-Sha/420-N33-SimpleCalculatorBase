﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculatorLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder resultString = new StringBuilder();

            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                //Change 2 - Iana 
                //Formatting and displaying like that: The value 1 plus the value 2 is equal to 3.
                                
                string formatedResult = result.ToString("#.##");
                string oper = CalculatorEngine.op;

                resultString.AppendFormat("The value {0} {1} the value {2} is equal to {3}",
                                          firstNumber, 
                                          oper, 
                                          secondNumber, 
                                          formatedResult);
                                
                Console.WriteLine(resultString);
               
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}