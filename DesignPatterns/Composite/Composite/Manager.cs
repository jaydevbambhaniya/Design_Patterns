using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public List<IEmployee> subOrdinates;

        public Manager(string name,string dept)
        {
            Name = name;
            Department = dept;
        }
        public void GetDetails(int level)
        {
            string space = new('\t', level);
            Console.WriteLine($"{space}Name: {Name}, Department: {Department} - Manager (Composite)");
            foreach(IEmployee e in subOrdinates)
            {
                e.GetDetails(level + 1);
            }
        }
    }
}
