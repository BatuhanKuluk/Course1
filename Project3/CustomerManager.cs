using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1,FirstName="Batuhan",LastName="Külük",Email="hahha@",Ctiy="İstanbul"},
                new Customer{Id=2,FirstName="Yağmur",LastName="Külük",Email="Yağmur@",Ctiy="İstanbul"},
                new Customer{Id=3,FirstName="Esra",LastName="Külük",Email="Esra@",Ctiy="İstanbul"},
                new Customer{Id=4,FirstName="Mahmut",LastName="Külük",Email="Mahmut@",Ctiy="İstanbul"}
            };
        }
        List<Customer> customers;
        public List<Customer> GetAll()
        {
            return customers;
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
