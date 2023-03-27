namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datasource
            /*List<string> fruits = new List<string> {
                "apple", "mango", "pear", "melon", "banana", "grapes"
            };*/

            //condition
            /*var my_query = (from i in fruits
                            where i.Length > 4
                            select i);*/

            //execution
            /* foreach (var item in my_query)
             {
                 Console.WriteLine($"{item}");
             }*/

            /*List<int> list = new List<int> {
                5, 10, 45, 74, 11
            };

            var query_list = list.Where(i => i > 21);

            foreach (var item in query_list)
            {
                Console.WriteLine(item);
            }*/
            /*-----------------------------------*/
            /*List<int> age = new List<int>
            { 10, 1, 3, 100, 12, 39, 65, 75};

            var age_sort_basic = from i in age
                                 orderby i descending
                                 select i;


            var age_sort_lambda = age.OrderByDescending(x => x);

            foreach (var item in age_sort_lambda)
            {
                Console.WriteLine(item);
            }

            foreach (var item in age_sort_basic)
            {
                Console.WriteLine(item);
            }*/


        }
    }
}