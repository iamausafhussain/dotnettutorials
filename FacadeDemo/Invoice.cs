namespace FacadeDemo
{
    internal class Invoice
    {
        public Invoice()
        {
            DisplayInvoice();
            SalesInvoice();
            UserInvoice();
        }

        public void DisplayInvoice()
        {
            Console.WriteLine("Order Invoice Created!!");
        }

        public void SalesInvoice()
        {
            Console.WriteLine("This is Sales Invoice");
        }

        public void UserInvoice()
        {
            Console.WriteLine("This is User Invoice");
        }
    }
}
