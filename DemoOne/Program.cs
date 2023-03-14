namespace DemoOne
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            string name;
            int count = 0;
            SortedList<int, string> list = new SortedList<int, string>();
            Console.WriteLine("Enter 0 to stop inputting name!");
            while (true)
            {
                Console.WriteLine("Enter a name");
                name = Console.ReadLine();
                if (name != "0")
                {
                    list.Add(count, name);
                    count++;
                }
                else
                {
                    break;
                }
            }
            foreach (int i in list.Keys)
            {
                Console.WriteLine($"{i}\t {list[i]}");
            }
        }
    }
}

