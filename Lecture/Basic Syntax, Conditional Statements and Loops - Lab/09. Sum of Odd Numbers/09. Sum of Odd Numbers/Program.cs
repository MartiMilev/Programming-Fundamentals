using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNum = 0;
            for (int i = 0; i < number; i++)
            {
                int currendOddNumber = 1 + (i * 2);
                Console.WriteLine(currendOddNumber);
                secondNum+=currendOddNumber;
            }
            Console.WriteLine($"Sum: { secondNum}");
        }
    }
}
