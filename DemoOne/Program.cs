namespace DemoOne
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Dictionary<int, Dictionary<int, string>> nested_dict = new Dictionary<int, Dictionary<int, string>>();

            nested_dict[0] = new Dictionary<int, string>();
            nested_dict[0][0] = "001";
            nested_dict[0][1] = "Ausaf";
            nested_dict[0][2] = "HR";
            nested_dict[0][3] = "C-128, Alpha, New York";

            nested_dict[1] = new Dictionary<int, string>();
            nested_dict[1][0] = "002";
            nested_dict[1][1] = "Asad";
            nested_dict[1][2] = "CEO";
            nested_dict[1][3] = "Alpha, Washington DC";

            nested_dict[2] = new Dictionary<int, string>();
            nested_dict[2][0] = "003";
            nested_dict[2][1] = "Anas";
            nested_dict[2][2] = "HR";
            nested_dict[2][3] = "Washington DC";

            nested_dict[3] = new Dictionary<int, string>();
            nested_dict[3][0] = "004";
            nested_dict[3][1] = "Yusuf";
            nested_dict[3][2] = "Software Engineer";
            nested_dict[3][3] = "Nevada";

            nested_dict[4] = new Dictionary<int, string>();
            nested_dict[4][0] = "005";
            nested_dict[4][1] = "Arshad";
            nested_dict[4][2] = "Software Engineer";
            nested_dict[4][3] = "China";

            Console.WriteLine("Enter Employee ID to find its Details: ");
            string emp_id = Console.ReadLine();

            foreach (var outer_index in nested_dict.Keys)
            {
                if (nested_dict[outer_index][0] == emp_id)
                {
                    Console.WriteLine($"Emp ID: {nested_dict[outer_index][0]}" +
                        $"\nEmp Name: {nested_dict[outer_index][1]}" +
                        $"\nDesignation: {nested_dict[outer_index][2]}" +
                        $"\nAddress: {nested_dict[outer_index][3]}");
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Not found!!");
            }
        }
    }
}

