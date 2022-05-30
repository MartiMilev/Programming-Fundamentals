using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for ( firstNum =firstNum; firstNum <= secondNum; firstNum++)
            {
            char result = Convert.ToChar(firstNum);
                Console.Write($" {result}");
            }

          
        }
    }
}
