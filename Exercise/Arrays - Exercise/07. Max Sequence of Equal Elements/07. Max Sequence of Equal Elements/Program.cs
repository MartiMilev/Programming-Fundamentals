using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{                                                                                 // 2 4 4 4 2
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longestNumbers = 0;
            int firstNum;
            int biggestNum = 0;
            int[] bigBiggestNum = new int[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNum = numbers[i];
                if (firstNum == numbers[i])
                {
                    longestNumbers++;
                    bigBiggestNum[0] = numbers[i];
                }
                else
                {
                    longestNumbers = 0;
                }

            }
            Console.WriteLine(String.Join(" ",bigBiggestNum));
        }
    }
}
