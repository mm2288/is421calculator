using System;
using CalculatorProject;
namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator class instantiation into a calculator object
            Calculator _calculator = new Calculator();

            //Console writes out options for function
            Console.WriteLine("Please respond with the letter reflecting the " +
                "function of your choosing:");
            Console.WriteLine("Addition: 'A'");
            Console.WriteLine("Division: 'D'");
            Console.WriteLine("Multiplication: 'M'");
            Console.WriteLine("Subtraction: 'S'");

            //Console asks for user input to determine function
            string function_input = Console.ReadLine();
            string choice = function_input.ToUpper();

            //Console asks for numbers and stores them
            Console.WriteLine("Enter the first number you would like to use " +
                "in your calculation:");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you would like to use " +
                "in your calculation:");
            int input_2 = Convert.ToInt32(Console.ReadLine());

            //Creates a calculation based on input
            _calculator.CreateCalculation(input_1, input_2, choice);
        }
    }
}
