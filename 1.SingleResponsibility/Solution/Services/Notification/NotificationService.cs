using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Services.Notification
{
    public class NotificationService : INotificationService
    {
        public void SendEmailInvoice(InvoiceModel invoice)
        {
            Console.WriteLine("Invoice was sent to the email");
        }
    }
}
