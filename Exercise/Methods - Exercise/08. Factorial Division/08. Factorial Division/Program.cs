using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result1 = Facturiel(firstNum);
            double result2 = Facturiel(secondNum);
            Console.WriteLine($"{result1 / result2:f2}");
        }

        private static double Facturiel(int number)
        {
            double result = 1;
            while (number!=1)
            {
                result *= number;
                number--;
            }
            return result;
        }




    }
}
