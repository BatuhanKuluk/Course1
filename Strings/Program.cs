using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "İstanbul";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Adana";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //string result = city +" "+ city2;
            //Console.WriteLine(result);
        }
    }
}
