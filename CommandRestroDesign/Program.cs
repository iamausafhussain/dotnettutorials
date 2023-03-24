namespace CommandRestroDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter\n1.To Deliver Order\n2.To Take Order");
            string order_type = Console.ReadLine();
            Order order = new Order();
            Waiter waiter = new Waiter();

            if (order_type == "1")
            {
                IRestro restro = new DeliverOrder(order);
                waiter.GetOrderAndExecute(restro);
            }
            else if (order_type == "2")
            {
                IRestro restro = new TakeOrder(order);
                waiter.GetOrderAndExecute(restro);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}