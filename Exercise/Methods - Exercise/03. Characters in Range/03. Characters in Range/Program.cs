﻿using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersRange(firstChar, secondChar);
        }
        static void CharactersRange(char firstChar,char secondChar)
        {
            int start = Math.Min(firstChar, secondChar);
            int end = Math.Max(firstChar,secondChar);

            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i+ " ");
            }
        }
        
       
    }
}
