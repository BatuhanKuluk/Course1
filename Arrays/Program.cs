using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            students[0] = "Batuhan";
            students[1] = "Onur";
            students[2] = "Birol";
            students[3] = "Ada";
            students[4] = "Ünal";

            string[] students2 = new string[6] { "BATUHAN", "ONUR", "BİROL", "ADA", "ÜNAL", "AHMET" };

            foreach (var student in students)
            {
                Console.WriteLine(student);

            }
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] numbers = new string[2,2]
            {
                {"Bir", "İki"},
                {"Üç","Dört" }
            };

            for (int i = 0; i <=numbers.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=numbers.GetUpperBound(1); j++)
                {
                    Console.WriteLine(numbers[i,j]);
                }
            }
           Console.ReadLine();
        }
    }
}
