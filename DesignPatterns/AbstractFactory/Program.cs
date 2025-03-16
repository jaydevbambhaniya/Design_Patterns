using Factory.AbstractFactory;
using Factory.AbstractFactory.Abstract;
using Factory.Enum;
using Factory.FactoryMethod;
using Factory.Model;

// Abstract Factory
BaseEmployee e1 = new PermanentEmployee("Sachin Tendulkar", EmployeeType.Permanent);
BaseEmployee e2 = new ContractEmployee("Ramesh Verma", EmployeeType.Contract);

EmployeeComputerFactory factory = new EmployeeComputerFactory();
IComputerFactory fac1 = factory.Create(e1);
IComputerFactory fac2 = factory.Create(e2);

Console.WriteLine("Fulltime Employee Computer Details: " +fac1.GetComputerInfo());
Console.WriteLine("Parttime Employee Computer Details: "+ fac2.GetComputerInfo());

// Factory Method
BaseEmployee e3 = EmployeeFactory.CreateEmployee(EmployeeType.Contract);
BaseEmployee e4 = EmployeeFactory.CreateEmployee(EmployeeType.Permanent);

Console.WriteLine("Permanent Employee: {0} ({1})", e4.GetHashCode(),e4.Type);
Console.WriteLine("Contract Employee: {0} ({1})", e3.GetHashCode(),e3.Type);