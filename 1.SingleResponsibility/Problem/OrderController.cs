namespace SingleResponsibility.Problem
{
    public class OrderController
    {
        public void SaveOrder(Order order)
        {
            try
            {
                InserOrder(order);
                var invoice = CreateInvoice(order);
                SendEmail(invoice);
                File.WriteAllText(@"c:\log.txt", "Completed");
            }
            catch
            {
                File.WriteAllText(@"c:\log.txt", "Not Completed");
            }
        }

        private Invoice CreateInvoice(Order order)
        {
            return new Invoice(order);
        }

        private static void SendEmail(Invoice invoice)
        {
            Console.WriteLine("Invoice was sent to the email");
        }

        private static void InserOrder(Order order)
        {
            Console.WriteLine("The order was inserted successfully");
        }
    }

    
}