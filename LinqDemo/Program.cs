namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int> {
                20, 40, 75, 45, 1, 10
            };
            var my_query = from i in my_list
                           select i;

            foreach (var item in my_query)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}