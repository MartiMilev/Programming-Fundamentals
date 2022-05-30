using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int order = 1; order <= nOrders; order++)
            {
            double priceForCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());

                double orderPrice = ((days * capsuleCount) * priceForCapsule);
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
