using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class SalaryDecorator : ISalaryCalculator
    {
        protected readonly ISalaryCalculator salaryCalculator;

        public SalaryDecorator(ISalaryCalculator calculator)
        {
            salaryCalculator = calculator;
        }
        public virtual double GetCalculatedSalary()
        {
            return salaryCalculator.GetCalculatedSalary();
        }
    }
}
