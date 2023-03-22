namespace BuilderApp
{
    public class SystemBuilder
    {
        private string Os_name;
        private int Ram_size;
        private int Hdd_size;
        private string Graphics;
        private string Display;

        public SystemBuilder setOsName(string os_name)
        {
            this.Os_name = os_name;
            return this;
        }
        public SystemBuilder setRamSize(int ram_size)
        {
            this.Ram_size = ram_size;
            return this;
        }
        public SystemBuilder setHddSize(int hdd_size)
        {
            this.Hdd_size = hdd_size;
            return this;
        }
        public SystemBuilder setGraphics(string graphics)
        {
            this.Graphics = graphics;
            return this;
        }
        public SystemBuilder setDisplay(string display)
        {
            this.Display = display;
            return this;
        }
        public Computer myPc()
        {
            return new Computer(this.Os_name, this.Ram_size, this.Hdd_size, this.Graphics, this.Display);
        }

    }
}
