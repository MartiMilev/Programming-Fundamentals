﻿using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            getMiddleChar(text);
        }

        private static void getMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[text.Length/2-1]);
                Console.WriteLine(text[text.Length/2]);
            }
            else
            {
                Console.WriteLine(text[text.Length/2]);
            }
        }
    }
}
