﻿namespace CommandPatternDemo
{
    internal class FlipUpCommand : ICommand
    {
        private Light _light;
        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
