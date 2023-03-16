namespace Accounting
{
    public interface IPayable
    {
        public int RetriveAmount(int amount);

        public void AddAmount(int amount);

        public void AddPaymentAddress(string address);
    }

    public class Person
    {
        string name;
        string home_address;
    }

    public class Employee : Person, IPayable
    {
        public int employee_id;
        private int employee_salary = 0;
        public string employee_emailid;

        public int RetriveAmount(int amount)
        {
            if (this.employee_salary >= amount && amount > 0)
            {
                this.employee_salary -= amount;
                return this.employee_salary;
            }
            else
            {
                return -1;
            }
        }
        public void AddAmount(int amount)
        {
            this.employee_salary += amount;
            Console.WriteLine($"Current amount: {this.employee_salary}");
        }
        public void AddPaymentAddress(string emailid)
        {
            this.employee_emailid = emailid;
            Console.WriteLine($"Email Id: {this.employee_emailid}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int user_choice, amount;
            string ch;
            Employee employee = new Employee();

            do
            {
                Console.WriteLine("Enter\n1.Add Payment Address\n2.Add " +
                    "Amount\n3.Retrive Amount\n\n");
                user_choice = Convert.ToInt32(Console.ReadLine());
                switch (user_choice)
                {
                    case 1:
                        Console.WriteLine("Enter Email ID");
                        string emailid = Console.ReadLine();
                        employee.AddPaymentAddress(emailid);
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount to Add: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        employee.AddAmount(amount);
                        break;
                    case 3:
                        Console.WriteLine("Enter Amount to retrive:");
                        amount = Convert.ToInt32(Console.ReadLine());
                        int result_amount = employee.RetriveAmount(amount);
                        if (result_amount == -1)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        else
                        {
                            Console.WriteLine($"Amount Retrived: {amount}");
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect Input!");
                        break;
                }
                Console.WriteLine("Press y/Y to continue(or Press any other key to exit)");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
        }
    }
}