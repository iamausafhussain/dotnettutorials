namespace ValRefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRef obj = new UserRef(10, 10);
            UserRef obj1 = new UserRef(10.4, 10.7);
            UserRef obj2 = new UserRef('y', 'a');
            UserRef obj3 = new UserRef("hello", "world");
        }
    }
}