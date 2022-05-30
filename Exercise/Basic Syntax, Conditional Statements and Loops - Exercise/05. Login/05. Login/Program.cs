using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLenght = username.Length - 1;
            string password ="";
            for (int value = usernameLenght ; value >=0; value--)
            {
                password +=username[value];
            }
            int countOfWrongPassword = 0;

            string inputPassword = Console.ReadLine();
            while(inputPassword!= password)
            {
                countOfWrongPassword++;
                if (countOfWrongPassword > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                    Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
