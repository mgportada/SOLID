
namespace OpenClosePrinciple
{
    public class SalaryCalculator
    {
        public decimal calculateAnnualSalary(Person person)
        {
            var TOTAL_ANNUAL_DAYS = 365;
            return person.DailyRate * TOTAL_ANNUAL_DAYS;
        }
    }
}
