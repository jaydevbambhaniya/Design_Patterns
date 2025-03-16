using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CommandExecutor
{
    public class Employee
    {
        public string? Name { get; set; }

        public Employee(string? name)
        {
            Name = name;
        }

        public void StartTask(string task)
        {
            Console.WriteLine($"{Name} is starting the task: {task}");
        }

        public void CompleteTask(string task)
        {
            Console.WriteLine($"{Name} has completed the task: {task}");
        }
    }
}
