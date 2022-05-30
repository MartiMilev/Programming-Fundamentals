using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;
            bool end = false;
            double change=0.0;
            double coins = 0;
            while(true)
            {
            string startStop = (Console.ReadLine());
                if (startStop == "Start")
                {
                    while (true)
                    {

                        string product = Console.ReadLine();
                        if (product =="End")
                        {
                            end = true;
                            break;
                        }
                        if (product != "Nuts" && product !="Water" && product !="Crisps" && product!="Soda" && product !="Coke")
                        {
                            Console.WriteLine("Invalid product");
                            continue;
                        }
                        if (product == "Nuts")
                        {
                            if (change <nuts)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                           else
                            {
                                Console.WriteLine("Purchased nuts");
                            }
                            change -= nuts;
                            continue;
                        }
                        else if (product == "Water")
                        {
                            if (change < water)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased water");
                            }
                            change -= water;
                            continue;
                        }
                        else if (product == "Crisps")
                        {
                            if (change < crisps)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased crisps");
                            }
                            change -= crisps;
                            continue;
                        }
                        else if (product == "Soda")
                        {
                            if (change < soda)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased soda");
                            }
                            change -= soda;
                            continue;
                        }
                        if (product == "Coke")
                        {
                            if (change < coke)
                            {
                                Console.WriteLine("Sorry, not enough money");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Purchased coke");
                            }
                            change -= coke;
                            continue;
                        }
                    }
                }    
                if (end == true)
                {
                Console.WriteLine($"Change: {change:f2}");
                return;
                }
                         coins = double.Parse(startStop);


                        if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                        {
                            Console.WriteLine($"Cannot accept {coins}");
                            continue;
                        }
                        change += coins;
            }
        }
    }
}
