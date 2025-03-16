using Command.AbstractCommand;
using Command.CommandExecutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CommandImplementor
{
    public class StartTaskCommand : ICommand
    {
        private readonly Employee _employee;
        private readonly string _task;

        public StartTaskCommand(Employee employee, string task)
        {
            _employee = employee;
            _task = task;
        }

        public void Execute()
        {
            _employee.StartTask(_task);
        }

        public void Undo()
        {
            Console.WriteLine($"Undo: {_employee.Name} is stopping the task: {_task}");
        }
    }
}
