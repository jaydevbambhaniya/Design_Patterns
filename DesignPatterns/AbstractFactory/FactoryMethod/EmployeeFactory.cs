using Factory.Enum;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public static class EmployeeFactory
    {
        public static BaseEmployee CreateEmployee(EmployeeType type)
        {
            BaseEmployee e = type switch
            {
                EmployeeType.Permanent => new PermanentEmployee(),
                EmployeeType.Contract => new ContractEmployee(),
                _ => throw new InvalidDataException()
            };

            return e;
        }
    }
}
