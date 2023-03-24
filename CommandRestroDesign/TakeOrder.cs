namespace CommandRestroDesign
{
    internal class TakeOrder : IRestro
    {
        Order _order;
        public TakeOrder(Order order)
        {
            _order = order;
        }
        public void Execute()
        {
            _order.GetOrder();
        }
    }
}
