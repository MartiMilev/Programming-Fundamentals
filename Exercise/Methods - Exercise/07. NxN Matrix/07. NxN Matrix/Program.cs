using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BuildMatrix(number);
        }

        private static void BuildMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int someNumber = number;
                Console.Write(someNumber + " ");
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write(someNumber + " ");
                }
                Console.WriteLine();
            }
        }
    }
}