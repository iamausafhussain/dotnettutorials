namespace HomeMainAppBuilder
{
    internal class Home
    {
        private string home_name;
        private string home_type;
        private int bhk;
        private int number_of_storey;
        private string set_extra_plot_area;

        public Home(string home_name, string home_type, int bhk, int number_of_storey, string set_extra_plot_area)
        {
            this.home_name = home_name;
            this.home_type = home_type;
            this.bhk = bhk;
            this.number_of_storey = number_of_storey;
            this.set_extra_plot_area = set_extra_plot_area;
        }

        public void DisplayHome()
        {
            Console.WriteLine($"Home Name: {this.home_name}\n" +
                $"Home Type: {this.home_type}\n" +
                $"BHK: {this.bhk}\n" +
                $"Number of Storey: {this.number_of_storey}\n" +
                $"Extra Plot Specification: {this.set_extra_plot_area}\n");
        }
    }
}
