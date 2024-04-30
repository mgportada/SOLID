

namespace OpenClosedPrinciple.Problem
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string[] Items { get; set; }
        public double TotalAmount { get; set; }
    }
}
