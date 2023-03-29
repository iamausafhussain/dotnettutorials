namespace GenericFunC
{
    internal class Program
    {
        public delegate int CustomDel(int first_number, int second_number);
        public static int Sum(int first_number, int second_number)
        {
            return first_number + second_number;
        }
        public static void Product(int first_number, int second_number)
        {
            Console.WriteLine($"The product is {first_number * second_number}");
        }
        static void Main(string[] args)
        {
            CustomDel obj = Sum;
            int result = obj.Invoke(10, 5);
            Console.WriteLine($"The Sum is {result}");

            /*Func<int, int, int> obj = (x, y) =>
            {
                return x + y;
            };

            int result = obj.Invoke(10, 4);
            Console.WriteLine("Result " + result);

            Action<int, int> action_obj = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            action_obj.Invoke(10, 20);

            Func<int, bool> predicate_obj = (x) =>
            {
                if (x > 5)
                {
                    return true;
                }
                return false;
            };

            bool p_result = predicate_obj.Invoke(3);
            Console.WriteLine(p_result);*/

            /*Predicate<int> predicate_obj = (x) =>
            {
                if (x > 5)
                {
                    return true;
                }
                return false;
            };
            bool p_result = predicate_obj.Invoke(3);
            Console.WriteLine(p_result);*/


        }
    }
}