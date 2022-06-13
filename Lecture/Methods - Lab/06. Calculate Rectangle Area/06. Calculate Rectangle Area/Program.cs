using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heigh = double.Parse(Console.ReadLine());
            double lengh = double.Parse(Console.ReadLine());

            GetRectangleArea(heigh, lengh);
            double area = GetRectangleArea(heigh, lengh);
            Console.WriteLine(area);
        }
        static double GetRectangleArea(double heigh,double lengh)
        {
            return heigh * lengh;
        }
    }
}
