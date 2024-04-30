

namespace OpenClosedPrinciple.Problem
{
    public class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                ExportToPDF(orders);
            }
            else if (type == ReportType.CSV)
            {
                ExportToEXCEL(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                ExportToCSV(orders);
            }
            else
            {
                throw new Exception("Invalid report type");
            }
        }

        public void ExportToPDF(List<Order> orders)
        {
            Console.WriteLine("Exporting to PDF");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Id: {order.OrderId}");
            }
        }

        public void ExportToCSV(List<Order> orders)
        {
            Console.WriteLine("Exporting to CSV");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Id: {order.OrderId}");
            }
        }

        public void ExportToEXCEL(List<Order> orders)
        {
            Console.WriteLine("Exporting to EXCEL");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Id: {order.OrderId}");
            }
        }

    }
}
