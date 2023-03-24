namespace CommandPatternDemo
{
    internal class FlipDownCommand : ICommand
    {
        private Light _light;
        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
