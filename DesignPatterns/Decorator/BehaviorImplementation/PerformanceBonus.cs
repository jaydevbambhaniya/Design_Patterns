using Decorator.Abstraction;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.BehaviorImplementation
{
    public class PerformanceBonus : SalaryDecorator
    {
        private readonly double _bonus;
        public PerformanceBonus(ISalaryCalculator calculator, double bonus) : base(calculator)
        {
            _bonus = bonus;
        }

        public override double GetCalculatedSalary()
        {
            return base.GetCalculatedSalary() + _bonus;
        }
    }
}
