using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lines = int.Parse(Console.ReadLine());
            for (int charakters = 1; charakters <= lines; charakters++)
            {
                char alphabet = char.Parse(Console.ReadLine());
                _ = char.ConvertFromUtf32(alphabet);
                 sum += alphabet;
            }
            Console.WriteLine($"The sum equals: { sum}");
        }
    }
}
