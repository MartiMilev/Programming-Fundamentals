using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNum =int.Parse(Console.ReadLine());
            int product = 0;
            if (secondNum > 10)
            {
                product = secondNum * number;
                Console.WriteLine($"{number } X {secondNum} = {product}");
                return;
            }

            for (int i = secondNum; i >= secondNum; i++)
            {
                product = number * secondNum;
                secondNum++;
                Console.WriteLine($"{number} X {i} = {product}");
                if (i == 10)
                {
                    return;
                }
            }
        }
    }
}