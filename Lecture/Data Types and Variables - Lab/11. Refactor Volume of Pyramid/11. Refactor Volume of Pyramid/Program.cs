using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
           double lenght =double.Parse (Console.ReadLine());

            double width =double.Parse (Console.ReadLine());

           double heigth =double.Parse (Console.ReadLine());

            sum = ((lenght * width * heigth)/3);

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {sum:f2}");

        }
    }
}
