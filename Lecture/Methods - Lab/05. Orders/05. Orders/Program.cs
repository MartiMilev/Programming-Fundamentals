using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            GetPriceOrders(order, quantity  );
            Console.WriteLine();
        }

        static void GetPriceOrders(string order, int quantity  )
        {
            double price = 0;
            double priceForCoffe = 1.50;
            double priceForWater = 1.0;
            double priceForCoke = 1.40;
            double priceForSnacks = 2.0;

            if (order == "coffee")
            {
                price += priceForCoffe;
            }
            else if (order == "water")
            {
                price += priceForWater;
            }
            else if (order == "coke")
            {
                price += priceForCoke;
            }
            else
            {
                price += priceForSnacks;
            }
            Console.WriteLine($"{price*quantity:f2}");


        }
    }

}

