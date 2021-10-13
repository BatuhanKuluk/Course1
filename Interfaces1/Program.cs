using System;

namespace Interfaces1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var cutomerManager = new CustomerManager();
            //var employeeManager = new EmployeeManager();
            var projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
         
            
        }
    }
}
