using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        private static void Main(string[] args)
        {
            // ForLoop();
            //number = WhileLoop(number);

            if (IsPrimeNumber(13))
            {
                Console.WriteLine("Asal Sayıdır.");
            }
            else
            {
                Console.WriteLine("Asal Değildir.");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;

        }

        private static int WhileLoop(int number)
        {
            while (number >= 0)
            {
                number--;
                Console.WriteLine(number);
            }

            return number;
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
