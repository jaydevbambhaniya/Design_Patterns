using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public class PermanentEmployee : BaseEmployee
    {
        public PermanentEmployee()
        {
            Type = Enum.EmployeeType.Permanent;
        }
        public PermanentEmployee(string name, EmployeeType type)
        {
            Name = name;
            Type = type;
        }
    }
}
