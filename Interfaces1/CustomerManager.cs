using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    public class CustomerManager : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
