
namespace OpenClosePrinciple
{
    public class SalaryCalculator
    {
        public double calculateAnnualSalary(Person person)
        {
            double dailyRate;
            var TOTAL_DAYS = 365;
            if (person is Manager)
            {
                dailyRate = 200;
                return dailyRate * TOTAL_DAYS;
            }
            else if (person is Employee)
            {
                dailyRate = 80;
                return dailyRate * TOTAL_DAYS;
            }
            else
            {
                throw new Exception("Invalid person type");
            }
        }
    }
}
