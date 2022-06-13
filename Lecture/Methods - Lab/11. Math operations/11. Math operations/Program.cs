using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));
        }
        static double Calculate(double first, char @operator, double second)
        {
            double result = 0;
            switch (@operator)
            {
                case '-':
                    result = first - second;
                    break;
               
                case '+':
                    result = first + second;
                    break;
                
                case '*':
                    result = first * second;
                    break;
                
                case '/':
                    result = first / second;
                    break;
            }
            return result;
        }
    }
}
