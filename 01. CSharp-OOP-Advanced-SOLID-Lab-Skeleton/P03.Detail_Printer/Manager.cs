using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public Manager(string name, ICollection<string> documents)
        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            return $"{Name}:{Environment.NewLine}" +
                   $"   {string.Join(Environment.NewLine + "   ", Documents)}{Environment.NewLine}";
        }
    }
}
