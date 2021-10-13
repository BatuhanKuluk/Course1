using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    public class EmployeeManager : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");

        }
    }
}
