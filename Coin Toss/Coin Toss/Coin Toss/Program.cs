using System;

namespace Coin_Toss
{
    class Program
    {
        static double FindPercentageofHeads(int numberofTimesCoinTossed)
        {

            Random rand = new Random();
            double headsCount = 0;
            int HEADS = 1;
            for (int i = 0; i < numberofTimesCoinTossed; i++)
            {
                int coinTossed = rand.Next(0, 2);
                if (coinTossed == HEADS)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                }

            }
            return (headsCount / numberofTimesCoinTossed) * 100;

        }

        static double FindPercentageofTails(double headsPercentage)
        {
            return 100 - headsPercentage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number Of Times You Want To Toss A Coin: ");
            int numberofTimesCoinTossed = int.Parse(Console.ReadLine());
            double headsPercentage = FindPercentageofHeads(numberofTimesCoinTossed);
            double tailsPercentage = FindPercentageofTails(headsPercentage);
            Console.WriteLine("Head Percentage: " + headsPercentage + " % ");
            Console.WriteLine("Tails Percentage: " + tailsPercentage + " % ");
        }
    }
}
