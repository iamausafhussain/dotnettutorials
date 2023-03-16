namespace ExceptioniHandlingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_one = 10, number_two = 0;

            try
            {
                int sum = number_one / number_two;

                Console.WriteLine("Next line");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Executed!!"); }
        }
    }
}