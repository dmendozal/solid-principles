using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        public InvoiceModel CreateInvoice(OrderModel order)
        {
            return new InvoiceModel(order);
        }
    }
}
