using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BaseSalary : ISalaryCalculator
    {
        private readonly double _baseAmount;

        public BaseSalary(double baseSalary)
        {
            _baseAmount = baseSalary;
        }
        public double GetCalculatedSalary()
        {
            return _baseAmount;
        }
    }
}
