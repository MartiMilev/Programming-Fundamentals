using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // създаваме масив , които чете от конзолата текс , взима дължината му и го разделя
            double[] numbers = new double[input.Length]; // създаваме нов масив , които е с дължината на първия 

            for (int i = 0; i < input.Length; i++) // цикъл за прехвърляне от първия към втория масив 
            {
                numbers[i] = double.Parse(input[i]); // double масива присвоява стойността на string масива 
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
