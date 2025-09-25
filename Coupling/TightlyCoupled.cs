namespace TightlyCoupled
{
    public class OrderService
    {
        private CreditCardPayment _payment; // 直接依賴具體類別

        public OrderService()
        {
            _payment = new CreditCardPayment(); // 強烈綁定
        }

        public void Checkout()
        {
            _payment.Pay(1000);
        }
    }

    public class CreditCardPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }
}