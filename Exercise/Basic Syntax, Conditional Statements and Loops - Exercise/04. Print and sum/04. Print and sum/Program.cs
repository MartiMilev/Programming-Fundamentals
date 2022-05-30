using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sumNum = 0;

            for (int secNum = startNum; secNum <= endNum; secNum++)
            {
                Console.Write($"{ secNum} ");
                sumNum += secNum;
            }
                Console.WriteLine();
                Console.WriteLine($"Sum: {sumNum}");
        }
    }
}
