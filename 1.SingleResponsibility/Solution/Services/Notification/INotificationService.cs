using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Services.Notification
{
    public interface INotificationService
    {
        void SendEmailInvoice(InvoiceModel invoice);
    }
}