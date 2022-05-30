using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double course = (people / capacity);
           
            
            Console.WriteLine(Math.Ceiling(course));
        }
    }
}
