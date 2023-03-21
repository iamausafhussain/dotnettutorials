namespace KeywordPractiseDemo
{
    internal class Program
    {
        public int AddParams(params int[] params_arr)
        {
            int result = 0;
            foreach (int param in params_arr)
            {
                result += param;
            }
            return result;
        }
        static void Main(string[] args)
        {
            /*Program program = new Program();
            int sum_result = program.AddParams(10, 20, 30, 30);
            Console.WriteLine($"The result is: {sum_result}");*/
        }
    }
}