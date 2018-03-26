using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            var employees = new List<IEmployee>();
            employees.Add(new Employee("Tonko"));
            var managerDocuments = new List<string>();
            managerDocuments.Add("Salary");
            managerDocuments.Add("Projects");
            employees.Add(new Manager("Pesho", managerDocuments));
            var printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
