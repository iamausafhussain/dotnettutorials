namespace ValRefDemo
{
    public class UserRef
    {
        public UserRef(int number_one, int number_two)
        {
            Console.WriteLine($"Sum: {number_one + number_two}");
        }

        public UserRef(double number_one, double number_two)
        {
            Console.WriteLine($"Float: {number_one + number_two}");
        }

        public UserRef(char number_one, char number_two)
        {
            Console.WriteLine($"Char: {number_one.ToString() + number_two.ToString()}");
        }

        public UserRef(string number_one, string number_two)
        {
            Console.WriteLine($"String: {number_one + number_two}");
        }
    }
}
