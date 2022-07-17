using SingleResponsibility.Solution.Model;
using SingleResponsibility.Solution.Repositories.Order;
using SingleResponsibility.Solution.Services.Invoice;
using SingleResponsibility.Solution.Services.Logger;
using SingleResponsibility.Solution.Services.Notification;

namespace SingleResponsibility.Solution
{
    public class OrderController
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private ILoggerService _loggerService;

        public OrderController(IOrderRepository orderRepository, 
                            INotificationService notificationService, 
                            IInvoiceService invoiceService, 
                            ILoggerService loggerService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
        }

        public void SaveOrder(OrderModel order)
        {
            try
            {
                _orderRepository.InserOrder(order);
                
                var invoice = _invoiceService.CreateInvoice(order);
                
                _notificationService.SendEmailInvoice(invoice);

                _loggerService.Info("Order completed.");
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message, e);
            }
        }
    }
}
