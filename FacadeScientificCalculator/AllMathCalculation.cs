namespace FacadeScientificCalculator
{
    internal class AllMathCalculation
    {
        public AllMathCalculation()
        {
            int choice = 0, user_choice, type;
            string calculation_name;
            do
            {
                Console.WriteLine("Press\n1.Arithmetic Calculation\n2.Statistical Calculation\n3.Logarithmic Calculation");
                user_choice = Convert.ToInt32(Console.ReadLine());
                switch (user_choice)
                {
                    case 1:
                        Console.WriteLine("Enter the type of Arithmetic calculation: \n1.Sum \n2.Sub \n3.Mul \n4.Divide");
                        type = Convert.ToInt32(Console.ReadLine());
                        Arithmetic arithmetic = new Arithmetic(type);
                        break;
                    case 2:
                        Console.WriteLine("Enter the type of Statistical calculation\n1.Mean\n2.Median");
                        type = Convert.ToInt32(Console.ReadLine());
                        Statistic statistic = new Statistic(type);
                        break;
                }

            } while (choice == 1);
        }
    }
}
