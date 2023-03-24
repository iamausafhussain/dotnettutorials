namespace CommandPatternDemo
{
    public class Switch
    {
        public void StoreAndExecute(ICommand command)
        {
            command.Execute();
        }
    }
}
