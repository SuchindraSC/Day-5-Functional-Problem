using System;

namespace Questions_and_Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number 1: ");
            double number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number 2: ");
            double number2 = int.Parse(Console.ReadLine());
            double quotient = number1 / number2;
            double remainder = number1 % number2;
            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + remainder);
        }
    }
}
