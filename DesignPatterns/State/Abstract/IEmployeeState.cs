using State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Abstract
{
    public interface IEmployeeState
    {
        void Handle(EmployeeContext context);
    }
}
