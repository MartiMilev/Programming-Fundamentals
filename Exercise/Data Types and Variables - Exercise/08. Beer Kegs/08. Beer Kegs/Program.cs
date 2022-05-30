using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double biggestKeg = double.MinValue;
            string biggestKegName = string.Empty;
            int nKeg = int.Parse(Console.ReadLine());
            for (int numOfKeg = 1; numOfKeg <= nKeg; numOfKeg++)
            {
                string keg=Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeForTheCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeForTheCurrentKeg >biggestKeg)
                {
                    biggestKeg = volumeForTheCurrentKeg;
                    biggestKegName = keg;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
