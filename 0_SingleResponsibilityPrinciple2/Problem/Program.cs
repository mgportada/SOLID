namespace OpenClosedPrinciple.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerName = "John Doe", OrderDate = DateTime.Now, Items = new string[] { "Shoes", "Shirt" }, TotalAmount = 100 },
                new Order { OrderId = 2, CustomerName = "Jane Doe", OrderDate = DateTime.Now, Items = new string[] { "Pants", "Socks" }, TotalAmount = 200 }
            };
            ReportingService reportingService = new ReportingService();
            reportingService.GenerateReport(orders, ReportType.PDF);

        }
    }
}