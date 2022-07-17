using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        public void InserOrder(OrderModel order)
        {
            Console.WriteLine("The order was inserted successfully");
        }
    }
}
