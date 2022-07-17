namespace DependencyInversion.Problem
{

    public class DataDogService
    {
        public void LogEvent(string message)
        {
            // Code to event on Data Dog
        }
    }

    /// <summary>
    /// Dependency Inversion: Debemos depender de abstracciones y NO de clases concretas
    /// </summary>
    /// DataDogService es una clase concreta y no una abstraccion
    public class OrderService
    {
        public readonly DataDogService _dataDogService;

        public OrderService(DataDogService dataDogService)
        {
            _dataDogService = dataDogService;   
        }

        public void GenerateOrder(Order order)
        {
            // Code to create orden

            // Send notification to Datadog
            _dataDogService.LogEvent("The order was created successfully.");
        }
    }

    public class Order
    {
        public int Id { get; set; }
    }
}