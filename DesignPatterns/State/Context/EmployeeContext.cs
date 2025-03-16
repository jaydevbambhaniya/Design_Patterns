using State.Abstract;
using State.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Context
{
    public class EmployeeContext
    {
        private IEmployeeState _state;

        public EmployeeContext()
        {
            _state = new WorkingState();
        }
        public void SetState(IEmployeeState state)
        {
            _state = state;
        }

        public void Process()
        {
            _state.Handle(this);
        }
    }
}
