using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());
            int[] ladyBugsField = new int[filedSize];
            string[] occoupiedIndex = Console.ReadLine().Split();

            for (int i = 0; i < occoupiedIndex.Length; i++)
            {
                int currentIndex = int.Parse(occoupiedIndex[i]);
                if (currentIndex >= 0 && currentIndex < filedSize)
                {
                    ladyBugsField[currentIndex] = 1;
                }
            }
            string[] comands = Console.ReadLine().Split();
            while (comands[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(comands[0]);
                while (currentIndex >= 0 && currentIndex < filedSize && ladyBugsField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugsField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = comands[1];
                    int flightLenght = int.Parse(comands[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }
                comands = Console.ReadLine().Split();

            }
            Console.WriteLine(string.Join(" ",ladyBugsField));
        }
    }
}
