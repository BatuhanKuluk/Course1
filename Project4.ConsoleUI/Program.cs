using Project4.Business;
using System;

namespace Project4.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
