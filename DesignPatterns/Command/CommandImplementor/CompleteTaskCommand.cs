using Command.AbstractCommand;
using Command.CommandExecutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CommandImplementor
{
    public class CompleteTaskCommand : ICommand
    {
        private readonly Employee _employee;
        private readonly string _task;

        public CompleteTaskCommand(Employee employee, string task)
        {
            _employee = employee;
            _task = task;
        }

        public void Execute()
        {
            _employee.CompleteTask(_task);
        }

        public void Undo()
        {
            Console.WriteLine($"Undo: {_employee.Name} is reopening the task: {_task}");
        }
    }
}
