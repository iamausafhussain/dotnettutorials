namespace FacadeDemo
{
    internal class Payment
    {
        public Payment()
        {
            IsPaymentSuccessful();
            OnlinePayment();
            CashPayment();
        }

        public void OnlinePayment()
        {
            Console.WriteLine("Rupees 5000, received on BharatPe");
        }

        public void CashPayment()
        {
            Console.WriteLine("Cash Payment Done!!");
        }

        public void IsPaymentSuccessful()
        {
            Console.WriteLine("Payment Successful");
        }
    }
}
