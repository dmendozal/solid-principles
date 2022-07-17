namespace InterfaceSegregation.Problem
{
    internal class Program
    {
        static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(6);
        }
    }
}
