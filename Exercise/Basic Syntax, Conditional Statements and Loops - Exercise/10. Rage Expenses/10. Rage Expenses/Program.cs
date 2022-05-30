using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;


            for (int secondGame = 1; secondGame <= lostGames; secondGame++)
            {
                if (secondGame % 2 == 0)
                {
                headset++;
                }
                if (secondGame % 3 == 0 )
                {
                    mouse++;
                    if (secondGame %3==0 && secondGame%2==0)
                    {
                        keyboard++;
                if (keyboard % 2 == 0)
                {
                    display++;
                }
                    }
                }
            }
            double totalPrice = (headset * headsetPrice) + (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice);
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");



        }
    }
}
