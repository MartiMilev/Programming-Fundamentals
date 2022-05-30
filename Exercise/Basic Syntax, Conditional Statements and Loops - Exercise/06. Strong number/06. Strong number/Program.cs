using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numberCoppy = num;
            int sum = 0;

            while (num > 0)
            {
            int sumNum = 1;
                int currentNum = num % 10;
                num/=10;
                for (int i = 2; i <=currentNum; i++)
                {
                    sumNum *= i;
                }
                sum += sumNum;
            }
            Console.WriteLine(sum == numberCoppy?"yes":"no");
        }
    }
}
