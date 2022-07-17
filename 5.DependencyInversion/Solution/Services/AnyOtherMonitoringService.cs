using DependencyInversion.Solution.Services.Interfaces;
namespace DependencyInversion.Solution.Services
{
    internal class AnyOtherMonitoringService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            // Code to log event on Any Other monitoring 
        }
    }
}
