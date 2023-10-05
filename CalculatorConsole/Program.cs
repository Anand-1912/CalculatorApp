using CalculatorLibrary;

namespace CalculatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The result of 1 + 2 is {Calculator.Add(1, 2)} ");
            Console.WriteLine($"The result of 2 - 1 is {Calculator.Subtract(1, 2)} ");
            Console.WriteLine($"The result of 3 * 2 is {Calculator.Multiply(3, 2)} ");
            Console.WriteLine($"The result of 10 / 2 is {Calculator.Divide(10, 2)} ");
            //Console.ReadLine();
        }
    }
}