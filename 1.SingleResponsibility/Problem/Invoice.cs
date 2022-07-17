namespace SingleResponsibility.Problem
{
    public class Invoice
    {
        private Order order;

        public Invoice(Order order)
        {
            this.order = order;
        }
    }
}