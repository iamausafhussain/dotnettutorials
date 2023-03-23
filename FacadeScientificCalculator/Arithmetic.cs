namespace FacadeScientificCalculator
{
    internal class Arithmetic
    {
        int first_number, second_number, result;
        public Arithmetic(int type)
        {
            Console.WriteLine("Enter first number:");
            this.first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            this.second_number = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Sum(this.first_number, this.second_number);
            }
            if (type == 2)
            {
                Sub(this.first_number, this.second_number);
            }
            if (type == 3)
            {
                Mul(this.first_number, this.second_number);
            }
            if (type == 4)
            {
                Div(this.first_number, this.second_number);
            }
        }

        public void Sum(int first_number, int second_number)
        {
            this.result = first_number + second_number;
            Console.WriteLine($"Summation: {this.result}");
        }

        public void Sub(int first_number, int second_number)
        {
            this.result = first_number - second_number;
            Console.WriteLine($"Subtraction: {this.result}");
        }
        public void Mul(int first_number, int second_number)
        {
            this.result = first_number * second_number;
            Console.WriteLine($"Multiplication: {this.result}");

        }
        public void Div(int first_number, int second_number)
        {
            this.result = first_number / second_number;
            Console.WriteLine($"Division: {this.result}");
        }
    }
}
