using System;

namespace DayOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a day");
            int day = int.Parse(Console.ReadLine());
            int dayofweek = DayOfTheWeek(year, month, day);
            Console.WriteLine("The day of the week is:");
           
            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 8)  
            {
                Console.WriteLine("Monday");
            }
            else if (day == 9)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 10)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day ==11)
            {
                Console.WriteLine("Thursday");
            }
            else if (day ==12)
            {
                Console.WriteLine("Friday");
            }
            else if (day ==13)
            {
                Console.WriteLine("Saturday");
            }
            else if (day ==14)
            {
                Console.WriteLine("Sunday");
            }
            else if (day ==15)
            {
                Console.WriteLine("Monday");
            }
            else if (day ==16)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day ==17)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day ==18)
            {
                Console.WriteLine("Thursday");
            }
            else if (day ==19)
            {
                Console.WriteLine("Friday");
            }
            else if (day ==20)
            {
                Console.WriteLine("Saturday");
            }
            else if (day ==21)
            {
                Console.WriteLine("Sunday");
            }
            else if (day ==22)
            {
                Console.WriteLine("Monday");
            }
            else if (day ==23)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day ==24)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day ==25)
            {
                Console.WriteLine("Thursday");
            }
            else if (day ==26)
            {
                Console.WriteLine("Friday");
            }
            else if (day ==27)
            {
                Console.WriteLine("Saturday");
            }
            else if (day ==28)
            {
                Console.WriteLine("Sunday");
            }
            else if (day ==29)
            {
                Console.WriteLine("Monday");
            }
            else if (day ==30)
            {
                Console.WriteLine("Tuesday");
            }
            else
            {
                Console.WriteLine("Answer not found");
            }

        }
        public static int DayOfTheWeek(int year, int month, int day)
        {
            //TODO
            return -1;
        }
    }
}
