using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public List<Calculation> Calculation = new List<Calculation>();


        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }
        public Calculator(double a, double b, string action)
        {
            CreateCalculation(a, b, action);
        }
        public void CreateCalculation(double a, double b, string action)
        {
            Func<double, double, double> _operation;

            //testing
            //AllOperations _operation = new AllOperations();



            switch (action)
            {
                case "A":
                    _operation = Operations.Sum;
                    break;
                case "S":
                    _operation = Operations.Subtraction;
                    break;
                case "M":
                    _operation = Operations.Multiplication;
                    break;
                case "D":
                    _operation = Operations.Division;
                    break;
                default:
                    _operation = Operations.Unassigned;
                    break;
            }
            var _calculation = new Calculation(a, b, _operation);

            Calculation.Add(_calculation);
            //Calculation.Subtract(_calculation);

            //Console.WriteLine(_calculation);

            _calculation.GetResult();


        }
    }
}
