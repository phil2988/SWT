using System;

namespace Tester
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Calculator.Calculator calculator = new Calculator.Calculator();

            Console.WriteLine("Testing calculator adding 1 and 1. Result is: " + calculator.Add(1, 1));
            
        }
    }
}
