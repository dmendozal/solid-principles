namespace SingleResponsibility.Solution.Model
{
    public class InvoiceModel
    {
        private readonly OrderModel order;

        public InvoiceModel(OrderModel order)
        {
            this.order = order;
        }
    }
}
