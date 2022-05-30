using System;

namespace _03._Passed_or_Failed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double studentGrade = double.Parse(Console.ReadLine());

            if (studentGrade <3)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
