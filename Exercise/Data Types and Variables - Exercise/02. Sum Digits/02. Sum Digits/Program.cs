using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumNum = 0;
            int result = 0;
            for (int i =num ; i >= num; i--)
            {
                
                sumNum = num % 10;
                result+=sumNum;
                num /= 10;
                if (num <= 0)
                {
                    break;
                }

            }
                Console.WriteLine(result);
        }
    }
}
