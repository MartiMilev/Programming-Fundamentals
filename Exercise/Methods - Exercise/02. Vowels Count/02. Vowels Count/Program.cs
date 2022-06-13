using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someName = Console.ReadLine();
            VowestCount(someName);
            Console.WriteLine(VowestCount(someName));
        }
        static int VowestCount(string someName)
        {

            int vowest = 0;
            for (int i = 0; i < someName.Length; i++)
            {
                char letters = someName[i];
                if (letters =='a')
                {
                    vowest++;
                }
                else if (letters =='A')
                {
                    vowest++;
                }
                else if (letters =='O')
                {
                    vowest++;
                }
                else if (letters =='o')
                {
                    vowest++;
                }
                else if (letters =='u')
                {
                    vowest++;
                }
                else if (letters =='U')
                {
                    vowest++;
                }
                else if (letters =='e')
                {
                    vowest++;
                }
                else if (letters =='E')
                {
                    vowest++;
                }
                else if (letters =='i')
                {
                    vowest++;
                }
                else if (letters =='I')
                {
                    vowest++;
                }
               
            }
            return vowest;
        }
    }
}
