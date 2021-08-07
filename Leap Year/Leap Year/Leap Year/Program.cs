using System;

namespace Leap_Year
{
    class Program
    {
        static void FindLeapYear()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 4 != 0)
                {
                    Console.WriteLine(+year + " is a Leap Year");
                }
            }
            else
            {
                Console.WriteLine(+year + " is not a Leap Year");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Year: ");
            FindLeapYear();
        }
    }
}
