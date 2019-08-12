using System;

namespace ProjectForTestingHiddenTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = 13;
            var b = 15;

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(a, b));
            Console.WriteLine(calculator.Subtract(a, b));
            Console.WriteLine(calculator.Multiply(a, b));
            Console.WriteLine(calculator.Divide(a, b));
        }
    }
}