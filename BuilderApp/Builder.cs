namespace BuilderApp
{
    public class Computer
    {
        private string Os_name;
        private int Ram_size;
        private int Hdd_size;
        private string Graphics;
        private string Display;

        public Computer(string os_name, int ram_size, int hdd_size, string graphics, string display)
        {
            this.Os_name = os_name;
            this.Ram_size = ram_size;
            this.Hdd_size = hdd_size;
            this.Graphics = graphics;
            this.Display = display;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"OS: {this.Os_name}\nRam: {this.Ram_size}\nHDD: " +
                $"{this.Hdd_size}\nGraphics: {this.Graphics}\nDisplay: " +
                $"{this.Display}");
        }
    }
}
