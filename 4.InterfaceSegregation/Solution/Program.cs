using InterfaceSegregation.Solution.Services.Burger;

namespace InterfaceSegregation.Solution
{
    internal class Program
    {
        static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(4);
        }
    }
}
