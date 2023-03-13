namespace TestPro
{
    public class Program
    {
        public double Sum(double number_one, double number_two)
        {
            return number_one + number_two;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            double result = program.Sum(1, 2);

            Calculator calculator = new Calculator();

            Console.WriteLine($"Result: {result}");
        }
    }

    public class Calculator : Program
    {
        public double Sub(double number_one, double number_two)
        {
            return number_one - number_two;
        }
    }
}