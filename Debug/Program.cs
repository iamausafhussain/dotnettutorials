namespace Debug
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String isContinue;

            Calculator calculator = new Calculator();
            do
            {
                Console.WriteLine("Press\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n" +
                    "5. Square\n6. Cube\n7. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        int number_one, number_two;
                        Console.WriteLine("Enter number 1: ");
                        number_one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number_two = Convert.ToInt32(Console.ReadLine());

                        double result = calculator.Sum(number_one, number_two);
                        Console.WriteLine($"The sum is: {result}");
                        break;
                    case 2:
                        Console.WriteLine("Enter number 1: ");
                        number_one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number_two = Convert.ToInt32(Console.ReadLine());

                        result = calculator.Subtract(number_one, number_two);
                        Console.WriteLine($"After Subtracting, value is: {result}");
                        break;
                    case 3:
                        Console.WriteLine("Enter number 1: ");
                        number_one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number_two = Convert.ToInt32(Console.ReadLine());

                        result = calculator.Multiply(number_one, number_two);
                        Console.WriteLine($"After Multiplying, value is: {result}");
                        break;
                    case 4:
                        Console.WriteLine("Enter number 1: ");
                        number_one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number_two = Convert.ToInt32(Console.ReadLine());

                        if(number_two == 0)
                        {
                            Console.WriteLine("Cannot divide by 0");
                        }
                        else
                        {
                            result = calculator.Divide(number_one, number_two);
                            Console.WriteLine($"After Dividing, value is: {result}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the number");
                        number_one = Convert.ToInt32(Console.ReadLine());

                        if (number_one == 0)
                        {
                            Console.WriteLine("Cannot square 0");
                        }
                        else
                        {
                            result = calculator.Square(number_one);
                            Console.WriteLine($"Square of {number_one} is: {result}");
                        }

                        break;
                    case 6:
                        Console.WriteLine("Enter the number");
                        number_one = Convert.ToInt32(Console.ReadLine());

                        if (number_one == 0)
                        {
                            Console.WriteLine("Cannot square 0");
                        }
                        else
                        {
                            result = calculator.Cube(number_one);
                            Console.WriteLine($"Square of {number_one} is: {result}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Thank You!!");
                        return;
                    default:
                        Console.WriteLine("Incorrect Responce!!");
                        break;
                }
                Console.WriteLine("Do you want to continue. (Press y/Y/Yes/yes/YES) or Press any key to exit!!");
                isContinue = Console.ReadLine();
            } while (isContinue == "y" || isContinue == "Yes" || isContinue == "Y"||isContinue == "yes"||isContinue == "YES");
        }
    }
}
 
class Calculator
{
    public double Sum(double number_one, double number_two)
    {
        double result = number_one + number_two;
        return result;
    }

    public double Subtract(double number_one, double number_two) 
    { 
        return number_one - number_two;
    }

    public double Multiply(double number_one, double number_two)
    {
        return number_one * number_two;
    }

    public double Divide(double number_one, double number_two)
    {
        return number_one / number_two;
    }

    public double Square(double number_one)
    {
        return number_one * number_one;
    }

    public double Cube(double number_one)
    {
        return number_one * number_one * number_one;
    }
}