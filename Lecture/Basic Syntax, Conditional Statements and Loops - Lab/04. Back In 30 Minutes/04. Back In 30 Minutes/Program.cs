using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

             if (minute < 30)
            {
                minute+=30;
            }
            else if (minute >= 30)
            {
                hour++;
                minute -=30;

            }
             if (hour > 23 )
            {
                hour = 0;
            }
          
            Console.WriteLine($"{hour}:{minute:D2}");
        }
    }
}
