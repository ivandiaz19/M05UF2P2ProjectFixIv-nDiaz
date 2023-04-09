using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            float num;
            string response;
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            num = int.Parse(response);
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(float number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number == 3)
                return true;
            if (number == 5)
                return true;
            if (number == 7)
                return true;
            if (number == 11)
                return true;
            if (number == 13)
                return true;
            if (number == 17)
                return true;
            if (number == 19)
                return true;
            if (number == 23)
                return true;
            if (number == 29)
                return true;
            if (number == 31)
                return true;
            if (number == 37)
                return true;
            if (number == 41)
                return true;
            if (number == 43)
                return true;
            if (number == 47)
                return true;
            if (number == 53)
                return true;
            if (number == 59)
                return true;
            if (number == 61)
                return true;
            if (number == 67)
                return true;
            if (number == 71)
                return true;
            if (number == 73)
                return true;
            if (number == 79)
                return true;
            if (number == 83)
                return true;
            if (number == 89)
                return true;
            if (number == 97)
                return true;
            if (number % 2 == 0)
                return false;

            //TODO
            return false;
        }
    }
}
