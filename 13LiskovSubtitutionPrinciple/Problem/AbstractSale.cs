

namespace LiskovSubtitutionPrinciple.Problem
{
    public abstract class AbstractSale
    {
        protected decimal amount;
        protected decimal price;
        protected string customer;
        protected decimal taxes;

        public abstract decimal Generate();
        public abstract decimal CalculateTaxes();
    }


}
