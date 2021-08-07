using System;

namespace Largest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Num3;
            Console.WriteLine("Enter the First Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("The Largest Number is " + Num1);
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("The Largest Number is " + Num2);
            }
            else
            {
                Console.WriteLine("The Largrest Number is " + Num3);
            }
        }
    }
}
