using System;
public class PrintExample
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isBigger = false;
        int current = 1;

        for (int rolls = 1; rolls <= n; rolls++)
        {
            for (int cols = 1; cols <= rolls; cols++)
            {
                if (current > n)
                {
                    isBigger = true;
                    break;
                }
                    current = rolls;
                Console.Write(current + " ");
            }
            if (isBigger)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}
