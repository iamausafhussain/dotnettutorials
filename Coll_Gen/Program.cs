namespace Coll_Gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryTable dict = new DictionaryTable();


            Console.WriteLine("Press\n1. To Find using key\n2. To Find using values\n3. Exit\n\n");
            int user_input = Convert.ToInt32(Console.ReadLine());

            switch (user_input)
            {
                case 1:
                    dict.find_key();
                    break;
                case 2:
                    dict.find_value();
                    break;
                case 3: return;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
    }
}

public class DictionaryTable
{
    Dictionary<int, string> employee = new Dictionary<int, string>();

    public DictionaryTable()
    {
        employee.Add(12345, "Ausaf");
        employee.Add(54321, "Asad");
        employee.Add(67890, "Ramesh");
        employee.Add(09876, "Yuvraj");
        employee.Add(00000, "Ramakant");
        employee.Add(11111, "Tushar");
        employee.Add(22222, "Yusuf");

    }

    public void find_key()
    {
        int flag = 0;
        Console.WriteLine("Enter the phone number of user: ");
        int userPhoneNumber = Convert.ToInt32(Console.ReadLine());

        foreach (int i in employee.Keys)
        {
            if (i == userPhoneNumber)
            {
                Console.WriteLine($"Phone number: {userPhoneNumber}\t Name: {employee[i]}");
                break;
            }
            else
            {
                flag = 1;
                continue;
            }
        }
        if (flag == 1)
        {
            Console.WriteLine("Phone number not found!!");
        }
    }

    public void find_value()
    {
        int flag = 0;
        Console.WriteLine("Enter the Name of user: ");
        string userName = Console.ReadLine();

        foreach (int i in employee.Keys)
        {
            if (employee[i] == userName)
            {
                Console.WriteLine($"Phone number: {i}\t Name: {userName}");
                break;
            }
            else
            {
                flag = 1;
                continue;
            }
        }

        if (flag == 1)
        {
            Console.WriteLine("Name not found!!");
        }
    }
}

