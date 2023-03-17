namespace UserDefinedFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number = 536;
            int result = number.CountDigit();
            Console.WriteLine($"result: {result}");*/

            /*string name = "ausaf";
            string name_length = name.ReverseString();
            Console.WriteLine($"Reversed: {name_length}");*/

            int value_pass = 10;
            Console.WriteLine($"Before: {value_pass}");
            UserSpec.ValueRefFunc(ref value_pass);
            Console.WriteLine($"After: {value_pass}");
        }
    }
}