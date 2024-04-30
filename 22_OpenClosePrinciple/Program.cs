namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryCalculator = new SalaryCalculator();
            var employee = new Employee("John Doe");
            var manager = new Manager("Jane Doe");

            System.Console.WriteLine($"Employee annual salary: {salaryCalculator.calculateAnnualSalary(employee)}");
            System.Console.WriteLine($"Manager annual salary: {salaryCalculator.calculateAnnualSalary(manager)}");
        }
    }
}