using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
  public   class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Update();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Batuhan",
                LastName = "Külük",
                City = "Sinop"
            };
            Console.WriteLine(customer.FirstName);


            Console.ReadLine();


        }
    }       
    
}
