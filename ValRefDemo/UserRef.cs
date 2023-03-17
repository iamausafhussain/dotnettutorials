namespace ValRefDemo
{
    static class UserRef
    {
        public static void ValueRefFunc(out int receive_value)
        {
            receive_value *= 100;
            Console.WriteLine($"Inside ValueRefFunc: {receive_value}");
        }
    }
}
