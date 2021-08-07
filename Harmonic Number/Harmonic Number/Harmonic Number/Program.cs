using System;

namespace Harmonic_Number
{
    class Program
    {
        static double HarmonicNumber(int N)
        {
            double Hn = 0.0;
            for (int i = 1; i<=N; i++)
            {
                Console.Write("1/{0} , ", i);
                Hn += 1 / i;
            }
            return Hn;
        }
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter The Value of Nth Number: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHarmonic Series is given by: ");
            if (N <= 0)
            {
                Console.WriteLine("Sorry! This Number Is Not Acceptable. Enter The Valid Value of N");
            }
            else
            {
                double HarmonicSeries = HarmonicNumber(N);
            }
        }
    }
}
