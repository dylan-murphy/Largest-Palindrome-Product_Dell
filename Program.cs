using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0; //Set base max
            for (int i = 100; i < 1000; i++) //3 digit number (100 min 999 max)
            {
                for (int j = 100; j < 1000; j++) //Second 3 digit number
                {
                    if (PalidromeTest(i * j)) 
                    {
                        if (max < i*j)
                        {
                            max = i*j;
                            Console.WriteLine(i + " x " + j); //Display i + j list. (Last contains palidrome number)
                        }
                    }
                }
            }
            Console.WriteLine("-------");
            Console.WriteLine(max); //Largest Palidrome
            Console.WriteLine("-------");
            Console.ReadKey();
        }

        private static bool PalidromeTest(int input) //Test for palidrome
        {
            char[] digits = input.ToString().ToCharArray();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != digits[digits.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
