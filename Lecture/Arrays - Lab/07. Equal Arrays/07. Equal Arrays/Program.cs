using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
           for (int i = 0; i < firstArray.Length; i++)
            {
                int currentNum = firstArray[i];
                sum +=firstArray[i];
                int index = i;
                for (int j = 0; j < secondArray.Length;j++)
                {
                    if (currentNum != secondArray[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                        return;
                    }
                    break;
                }
            }
           Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
