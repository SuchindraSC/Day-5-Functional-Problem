using System;

namespace Check_Alphabets_Are_Vowels_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());
            int num = ch;
            if (num >= 48 && num <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'E':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'I':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'O':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'U':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("It Is Not Vowel");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
