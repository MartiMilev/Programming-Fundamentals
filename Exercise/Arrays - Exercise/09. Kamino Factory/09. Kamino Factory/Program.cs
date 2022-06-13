using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sequence lenght
            int sequenceLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] DNA = new int[sequenceLenght];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;
            int sample = 0;

            while (input != "Clone them!")
            {
                //current DNA info
                sample++;
                int[] currDNA = input.Split("!",
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                //Current DNA elements
                int currCount = 0;
                int currStartIndex = 0;
                int currentEndIndex = 0;
                int currDnaSum = 0;
                bool isCurrDnaBetter = false;
                int count = 0;

                for (int i = 0; i < currDNA.Length; i++)
                {
                    if (currDNA[i] != 1)
                    {
                        count = 0;
                        continue;

                    }
                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currentEndIndex = i;

                    }

                }
                //00 11 0 1 =>11 (endIndex =2) => (startIndex 2-2=0+1=>1)
                currStartIndex = currentEndIndex - currCount + 1;
                currDnaSum = currDNA.Sum();

                //CHECK CURRENT DNA WITH BEST DNA

                if (currCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                }
                else if (currStartIndex == dnaStartIndex)
                {
                    if (currDnaSum == dnaSum)
                    {
                        isCurrDnaBetter = true;
                    }
                }
                if (isCurrDnaBetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStartIndex=currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }
                input  =Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(String.Join(" ",DNA));

        }
    }
}
