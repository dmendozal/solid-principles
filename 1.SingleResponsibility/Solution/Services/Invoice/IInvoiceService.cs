using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Services.Invoice
{
    public interface IInvoiceService
    {
        InvoiceModel CreateInvoice(OrderModel order);
    }
}