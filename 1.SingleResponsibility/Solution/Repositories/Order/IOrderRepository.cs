using SingleResponsibility.Solution.Model;

namespace SingleResponsibility.Solution.Repositories.Order
{
    public interface IOrderRepository
    {
        void InserOrder(OrderModel order);
    }
}