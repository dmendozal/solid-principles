using DependencyInversion.Solution.Services.Interfaces;

namespace DependencyInversion.Solution.Services
{
    internal class DataDogService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            // Code to log event on Datadog
        }
    }
}
