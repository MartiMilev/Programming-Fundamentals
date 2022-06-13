using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //               valid password
            //•	It should contain 6 – 10 characters(inclusive)
            //•	It should contain only letters and digits
            //•	It should contain at least 2 digits

            //                invalid password
            //•	"Password must be between 6 and 10 characters"
            //•	"Password must consist only of letters and digits"
            //•	"Password must have at least 2 digits"

            string password = Console.ReadLine();
            bool isPasswordLenghtValid=validatePasswordLenght(password);
            bool isPaswwordCounteinsValidSimbols = validatePasswordText(password);
            bool isDigitInPasswordAtList = validatePasswordDigit(password);

            if (!isPasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPaswwordCounteinsValidSimbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitInPasswordAtList)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordLenghtValid && isDigitInPasswordAtList && isPaswwordCounteinsValidSimbols)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool validatePasswordDigit(string password)
        {
            int count = 0;
            foreach(char simbols in password)
            {
                if (char.IsDigit(simbols))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool validatePasswordText(string password)
        {
            foreach(char simbol in password)
            {
                if (!char.IsLetterOrDigit(simbol))
                {
                    return false;
                }
               
            }
            return true;
        }

        private static bool validatePasswordLenght(string password)
        {
           return password.Length >=6 && password.Length <=10;
        }
    }
}
