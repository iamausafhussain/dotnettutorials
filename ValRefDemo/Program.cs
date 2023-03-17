namespace ValRefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a class


            */

            int value_pass = 10;
            Console.WriteLine($"Before: {value_pass}");
            UserRef.ValueRefFunc(out value_pass);
            Console.WriteLine($"After: {value_pass}");





        }
    }
}