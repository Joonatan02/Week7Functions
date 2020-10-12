using System;
using System.Security.Cryptography.X509Certificates;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");
            string UserInput = Console.ReadLine();
            AgeCalc(UserInput);
        }

        public static void AgeCalc(string yearOfBirth)
        {
            int UserYearOfBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"You are {2020 - UserYearOfBirth} years old!");
        }

    }
}
