using Command.AbstractCommand;
using Command.CommandExecutor;
using Command.CommandImplementor;
using Command.Manager;

Employee e1 = new Employee("Alice");

ICommand task1 = new StartTaskCommand(e1, "Code Review");
ICommand task2 = new CompleteTaskCommand(e1, "Bug Fixing");

CommandManager manager = new CommandManager();

manager.ExecuteCommand(task2);
manager.ExecuteCommand(task1);

manager.UndoCommand();
