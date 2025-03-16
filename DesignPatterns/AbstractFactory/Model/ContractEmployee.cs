using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public class ContractEmployee : BaseEmployee
    {
        public ContractEmployee()
        {
            Type = EmployeeType.Contract;
        }
        public ContractEmployee(string name,EmployeeType type)
        {
            Name = name;
            Type = type;
        }
    }
}
