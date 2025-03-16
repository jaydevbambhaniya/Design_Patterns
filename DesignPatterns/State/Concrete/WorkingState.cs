using State.Abstract;
using State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Concrete
{
    public class WorkingState : IEmployeeState
    {
        public void Handle(EmployeeContext context)
        {
            Console.WriteLine("Employee is working.");
            context.SetState(new VacationState());
        }
    }
}
