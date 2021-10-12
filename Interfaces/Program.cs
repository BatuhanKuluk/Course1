using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Batuhan", LastName = "Külük", Address = "İstanbul" });
            PersonManager manager1 = new PersonManager();
            manager1.Add(new Student { Id = 2, FirstName = "Yağmur", LastName = "Külük", Departmant = "Adana" });
            
            //Customer customer = new Customer
            //{
            //    Id = 3,
            //    FirstName = "Onur",
            //    LastName = "Güler",
            //    Address = "Samsun"
            //};
            //Console.WriteLine(customer.FirstName);


            Console.ReadLine();
        }
    }
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    public class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    public class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    public class PersonManager
    {
        public void Add(IPerson  person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            


        }

        public void Add(Student student)
        {
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
        }
    }
}
