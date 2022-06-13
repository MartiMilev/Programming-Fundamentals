using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            SumNumPower(num, power);
        }
        static void SumNumPower(double num,double power)
        {
            Console.WriteLine(Math.Pow(num,power));
        }
    }
}
