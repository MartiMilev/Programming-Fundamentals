using System;
using System.Linq;
namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] wagonsLenght = new int[wagons];
            int sum = 0;
            for (int i = 0; i < wagonsLenght.Length; i++)
            {
                int person = int.Parse(Console.ReadLine());
                wagonsLenght[i] = person;
                sum+=person;
            }
            Console.WriteLine("{0}", string.Join(" ", wagonsLenght));
            Console.WriteLine(sum);
        }
    }
}
