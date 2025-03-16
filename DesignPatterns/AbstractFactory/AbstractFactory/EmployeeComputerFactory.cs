using Factory.AbstractFactory.Abstract;
using Factory.AbstractFactory.Implementation;
using Factory.Enum;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    public class EmployeeComputerFactory
    {
        public IComputerFactory Create(BaseEmployee employee)
        {
            IComputerFactory factory = employee.Type switch
            {
                EmployeeType.Contract => new DellDesktopFactory(),
                EmployeeType.Permanent => new AppleLaptopFactory(),
                _ => throw new InvalidDataException()
            };

            return factory;
        }
    }
}
