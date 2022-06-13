using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
            bool biggestNumber = true;

                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        biggestNumber = false;
                    }
                }
                if (biggestNumber)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }

        }
    }
}
