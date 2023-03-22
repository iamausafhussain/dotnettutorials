namespace HomeMainAppBuilder
{
    internal class SystemHomeBuilder
    {
        private static int counter = 0;

        public static SystemHomeBuilder instance = null;
        public static SystemHomeBuilder GetBuilderInstance
        {
            get
            {
                if (instance == null)
                    instance = new SystemHomeBuilder();
                return instance;
            }
        }

        private string home_name;
        private string home_type;
        private int bhk;
        private int number_of_storey;
        private string set_extra_plot_area;
        public SystemHomeBuilder SetHomeName(string home_name)
        {
            this.home_name = home_name;
            return this;
        }
        public SystemHomeBuilder SetHomeType(string home_type)
        {
            this.home_type = home_type;
            return this;
        }
        public SystemHomeBuilder SetBhk(int bhk)
        {
            this.bhk = bhk;
            return this;
        }
        public SystemHomeBuilder SetStorey(int number_of_storey)
        {
            this.number_of_storey = number_of_storey;
            return this;
        }
        public SystemHomeBuilder SetExtraSpecs(string set_extra_plot_area)
        {
            this.set_extra_plot_area = set_extra_plot_area;
            return this;
        }
        public Home BuildMyHome()
        {
            return new Home(this.home_name, this.home_type, this.bhk, this.number_of_storey, this.set_extra_plot_area);
        }

        private SystemHomeBuilder()
        {
            counter++;
            Console.WriteLine($"Conter: {counter}");
        }
    }
}
