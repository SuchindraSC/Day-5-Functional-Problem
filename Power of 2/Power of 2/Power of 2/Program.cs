using System;

namespace Power_of_2
{
    class Program
    {
        static double FindPowerof2(double N)
        {
            double Power = Math.Pow(2, N);
            return Power;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value of N: ");
            double N = Convert.ToDouble(Console.ReadLine());
            if (N <= 0 || N > 31)
            {
                Console.WriteLine("You Have Entered A Wrong! Please Enter A Right Number");
            }
            else
            {
                double Powerof2 = FindPowerof2(N);
                Console.WriteLine("\n2^" + N + " = " + Powerof2);
            }
        }
    }
}
