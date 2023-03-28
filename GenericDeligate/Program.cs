namespace GenericDeligate
{
    internal class Program
    {
        public delegate void CustomDel(int first_number, int second_number);
        public static void Sum(int first_number, int second_number)
        {
            Console.WriteLine($"The sum is {first_number + second_number}");
        }
        public static void Product(int first_number, int second_number)
        {
            Console.WriteLine($"The product is {first_number * second_number}");
        }
        static void Main(string[] args)
        {
            CustomDel del = Program.Sum;
            del += Program.Product;
            del.Invoke(5, 3);
        }
    }
}