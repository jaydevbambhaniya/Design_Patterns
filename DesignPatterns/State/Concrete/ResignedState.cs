using State.Abstract;
using State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Concrete
{
    public class ResignedState : IEmployeeState
    {
        public void Handle(EmployeeContext context)
        {
            Console.WriteLine("Employee has resigned, no further states possible.");
        }
    }
}
