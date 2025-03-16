using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name,string department)
        {
            Name = name;
            Department = department;
        }
        public void GetDetails(int level)
        {
            string space = new('\t', level);
            Console.WriteLine($"{space}Name: {Name}, Department: {Department} - Employee (Leaf)");
        }
    }
}
