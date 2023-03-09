namespace nine
{
    internal class Program
    {
        delegate void Del(int x);

        public static void square(int x)
        {
            Console.WriteLine($"Sum is : {x * x}");
        }

        public static void Main(string[] args)
        {
            Del d = new Del(Program.square);
            d.Invoke(5);
        }
    }
}