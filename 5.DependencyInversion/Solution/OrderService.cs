using DependencyInversion.Solution.Models;
using DependencyInversion.Solution.Services.Interfaces;

namespace DependencyInversion.Solution
{
    internal class OrderService
    {
        private readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            // Todo: Code to create the order

            // Send notification to monitoring service
            _eventNotificationService.LogEvent("The order was created successfully");
        }
    }
}
