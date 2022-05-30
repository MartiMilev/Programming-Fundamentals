using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int takeItWater = 0;
            int timesPour = int.Parse(Console.ReadLine());
            for (int pour = 1; pour <= timesPour; pour++)
            {
                int quantities = int.Parse(Console.ReadLine());
                takeItWater += quantities;
                if (CAPACITY< takeItWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                    takeItWater -= quantities;
                }
            }
            Console.WriteLine(takeItWater);
        }
    }
}
