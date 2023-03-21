namespace LaptopConfig
{
    public class Laptop
    {
        public const string name = "Asus";
        public const int price = 80000;
        public const string processor = "Intel core i7";
        public const string ram = "6GB";
        public const string hard_drive = "1TB";


    }

    public class Product : Laptop
    {
        public Product()
        {
            Console.WriteLine($"Name: {Laptop.name}");
            Console.WriteLine($"Price: {Laptop.price}");
            Console.WriteLine($"Processor: {Laptop.processor}");
            Console.WriteLine($"Ram: {Laptop.ram}");
            Console.WriteLine($"Hard Drive: {Laptop.hard_drive}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
        }
    }
}