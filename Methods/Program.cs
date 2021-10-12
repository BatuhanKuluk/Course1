using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(3,1);
            var result = Add2(3,1);
            Console.WriteLine(result);


            Console.WriteLine(Carp(2,3,4));
            Console.WriteLine(Carp(5,5));

            Console.WriteLine(Hesap(2,3,4,5,6,7,8,9));


            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1,int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int Carp(int number1 , int number2 , int number3)
        {
            return number1 * number2 * number3;
        }
        static int Carp(int number1 , int number2)
        {
            return number1 * number2;
        }
        static int Hesap(params int [] numbers)
        {
            return numbers.Sum();
        }
    }
}
