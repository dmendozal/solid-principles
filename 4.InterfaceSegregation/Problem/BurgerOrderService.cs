namespace InterfaceSegregation.Problem
{
    internal class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            // Code to order a burger
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
