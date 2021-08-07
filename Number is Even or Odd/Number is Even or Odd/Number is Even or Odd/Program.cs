using System;

namespace Number_is_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter The Number: ");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("\nThe Given Number is Even");
            }
            else
            {
                Console.WriteLine("\nThe Given Number is Odd");
            }
        }
    }
}
