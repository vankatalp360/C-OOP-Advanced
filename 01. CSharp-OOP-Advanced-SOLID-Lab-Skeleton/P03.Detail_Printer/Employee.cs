using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Name}: {Environment.NewLine}";
        }
    }
}
