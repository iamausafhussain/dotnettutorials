namespace CommandRestroDesign
{
    internal class Waiter
    {
        public void GetOrderAndExecute(IRestro command)
        {
            command.Execute();
        }
    }
}
