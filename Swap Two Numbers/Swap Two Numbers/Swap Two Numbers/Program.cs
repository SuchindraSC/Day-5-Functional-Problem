using System;

namespace Swap_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Befor Swapping: ");
            Console.WriteLine("\nEnter the First Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Second Number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nAfter Swapping: ");
            Console.WriteLine("\nFirst Number: " + num1);
            Console.WriteLine("\nSecond Number: " + num2);
            Console.ReadLine();
        }
    }
}
