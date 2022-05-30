using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceForLightsabers = double.Parse(Console.ReadLine());
            double priceForRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());


            double studentsForLightsabersTenPercent = Math.Ceiling(numberOfStudents * 0.1);
            double totalPriceForLightsabers = (priceForLightsabers * (numberOfStudents + studentsForLightsabersTenPercent));

            double totalFreeBelts = numberOfStudents / 6;

            double totalPriceForBelt = priceOfBelts * numberOfStudents - (totalFreeBelts * priceOfBelts);
            double totalPriceForRobes = (priceForRobes * numberOfStudents);

            double totalPrice = totalPriceForLightsabers + totalPriceForBelt + totalPriceForRobes;
            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double nedostig = totalPrice - amountOfMoney;
                Console.WriteLine($"John will need {nedostig:f2}lv more.");
            }
        }
    }
}
