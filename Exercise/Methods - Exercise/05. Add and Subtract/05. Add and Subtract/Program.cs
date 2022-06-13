using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirtNum = int.Parse(Console.ReadLine());

            SumFirstAndSecond(firstNum, secondNum, thirtNum);

        }

        private static void SumFirstAndSecond(int firstNum, int secondNum, int thirtNum)
        {
            firstNum+=secondNum;
            EndSum(firstNum, thirtNum);
        }

        private static void EndSum(int firstNum, int thirtNum)
        {
            Console.WriteLine(firstNum-thirtNum);
        }
    }
}
