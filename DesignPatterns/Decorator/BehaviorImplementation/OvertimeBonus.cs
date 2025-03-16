using Decorator.Abstraction;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.BehaviorImplementation
{
    public class OvertimeBonus : SalaryDecorator
    {
        private readonly double _hourlyRate;
        private readonly int _hours;
        public OvertimeBonus(ISalaryCalculator calculator,double rate,int hour) : base(calculator)
        {
            _hourlyRate = rate;
            _hours = hour;
        }
        public override double GetCalculatedSalary()
        {
            return base.GetCalculatedSalary() + _hours*_hourlyRate;
        }
    }
}
