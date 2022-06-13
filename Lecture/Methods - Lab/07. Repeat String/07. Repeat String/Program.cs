using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            RepeatSomeTextTimes(someText, times);
        }

        static void RepeatSomeTextTimes(string someText, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(someText);
            }
        }
    }
}
