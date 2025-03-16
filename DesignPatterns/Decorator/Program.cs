
using Decorator;
using Decorator.Abstraction;
using Decorator.BehaviorImplementation;

Console.WriteLine(CalculateSalary(4000, false, true, 1000, 0, 0));

Console.WriteLine(CalculateSalary(5000, true, true, 1000, 500, 4));

static double CalculateSalary(double baseSalary,bool overtime,bool performance,double bonus,double hourlyRate,int hours)
{
    ISalaryCalculator salaryCalculator = new BaseSalary(baseSalary);
    if (overtime)
    {
        salaryCalculator = new OvertimeBonus(salaryCalculator, hourlyRate,hours);
    }
    if (performance)
    {
        salaryCalculator = new PerformanceBonus(salaryCalculator, bonus);
    }
    return salaryCalculator.GetCalculatedSalary();
}