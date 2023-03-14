namespace Coll_Gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employee = new Dictionary<int, string>();

            employee.Add(123, "ausaf");
            employee.Add(321, "asad");

            foreach (int i in employee.Keys)
            {
                Console.WriteLine($"{i} {employee[i]}");
            }
        }
    }
}