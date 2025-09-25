namespace LooselyCoupled
{
    // 先定義抽象介面
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    // OrderService 只依賴介面
    public class OrderService
    {
        private readonly IPayment _payment;

        public OrderService(IPayment payment)
        {
            _payment = payment;
        }

        public void Checkout()
        {
            _payment.Pay(1000);
        }
    }

    // 各種支付方式只要實作 IPayment
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    public class PaypalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}