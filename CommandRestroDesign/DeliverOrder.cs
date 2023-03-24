namespace CommandRestroDesign
{
    public class DeliverOrder : IRestro
    {
        Order _order;
        public DeliverOrder(Order order)
        {
            _order = order;
        }
        public void Execute()
        {
            _order.TakeOrder();
        }
    }
}
