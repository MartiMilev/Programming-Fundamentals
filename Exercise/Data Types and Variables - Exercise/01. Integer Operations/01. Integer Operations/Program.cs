﻿using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum=  int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int sumFirstNumAndSecondNum = firstNum + secondNum;
            int sumTheFirstSum = sumFirstNumAndSecondNum / thirdNum;
            int sumTheLastSum = sumTheFirstSum * fourthNum;
            Console.WriteLine(sumTheLastSum);
        }
    }
}
