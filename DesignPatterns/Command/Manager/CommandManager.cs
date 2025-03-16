using Command.AbstractCommand;
using Command.CommandExecutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Manager
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand last = _commandHistory.Pop();
                last.Undo();
            }
            else
            {
                Console.WriteLine("No Commands to Undo.");
            }
        }
    }
}
