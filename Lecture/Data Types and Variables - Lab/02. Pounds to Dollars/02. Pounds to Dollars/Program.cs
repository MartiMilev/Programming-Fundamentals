using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 British Pound = 1.31 Dollars

            double pound = double.Parse(Console.ReadLine());
            double poundToUSD = 1.31;
            double dollars = pound *poundToUSD;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
