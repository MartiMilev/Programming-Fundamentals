﻿using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < count; i++)
            {
                decimal numberSum = decimal.Parse(Console.ReadLine());
                sum+=numberSum;
            }
            Console.WriteLine(sum);
        }
    }
}
