namespace LinqMenuBased
{
    internal class Program
    {
        public static List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 4, Name ="Aruhi", Designation="HR"},
                new Employee {Id = 2, Name ="Ausaf", Designation="Junior Accountant"},
                new Employee {Id = 1, Name ="Yasmin", Designation="Senior Engineer"},
                new Employee {Id = 3, Name ="Gourav", Designation="CEO"},
            };
        static void Main(string[] args)
        {
            string ch = "No";
            int choice, user_choice;
            do
            {
                Console.WriteLine("\nEnter\n1.Odd Id\n2.Even Id\n3.Sort Ascending\n4.Sort Descending\n5.Find By Id\n6.Find By Name\n7.Show Name\n8.Exit");
                user_choice = Convert.ToInt32(Console.ReadLine());
                switch (user_choice)
                {
                    case 1:
                        Program.Odd();
                        break;
                    case 2:
                        Program.Even();
                        break;
                    case 3:
                        Program.Sort();
                        break;
                    case 4:
                        Program.SortDescending();
                        break;
                    case 5:
                        Console.WriteLine("Enter Id to Find");
                        int find_id = Convert.ToInt32(Console.ReadLine());
                        Program.FindById(find_id);
                        break;
                    case 6:
                        Console.WriteLine("Enter Id to Find");
                        string find_name = Console.ReadLine();
                        Program.FindByName(find_name);
                        break;
                    case 7:
                        Program.Show();
                        break;
                    case 8: return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                ch = Console.ReadLine();
            } while (ch == "yes" || ch == "Yes");
        }

        public static void Odd()
        {
            var odd_emp = employees.Where(i => i.Id % 2 != 0)
                .Select(i => i);

            foreach (var item in odd_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }

        public static void Even()
        {
            var even_emp = employees.Where(i => i.Id % 2 == 0)
                .Select(i => i);

            foreach (var item in even_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void Sort()
        {
            var sort_emp = employees.OrderBy(i => i.Id);

            foreach (var item in sort_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void SortDescending()
        {
            var sort_emp = employees.OrderByDescending(i => i.Id);

            foreach (var item in sort_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void FindById(int n)
        {
            var custom_emp = employees.Where(i => i.Id == n)
                .Select(i => i);

            foreach (var item in custom_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void FindByName(string n)
        {
            var custom_emp = employees.Where(i => i.Name == n)
                .Select(i => i);

            foreach (var item in custom_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void Show()
        {
            var show_name = from i in employees
                            select i;
            foreach (var item in show_name)
            {
                Console.WriteLine($"{item.Name}");
            }

            int name_choice, choice;
            string nch = "No";
            do
            {
                Console.WriteLine("\nEnter\n1.Starts with\n2.Contains\n3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a word:");
                        string start_ch = Console.ReadLine();
                        Program.StartSearch(start_ch);
                        break;
                    case 2:
                        Console.WriteLine("Enter a word:");
                        string contain_ch = Console.ReadLine();
                        Program.ContainSearch(contain_ch);
                        break;
                    case 3: return;
                }
                Console.WriteLine("Do want to add filter again");
                nch = Console.ReadLine();
            } while (nch == "yes" || nch == "Yes");


        }
        public static void StartSearch(string ch)
        {
            var search_query = from i in employees
                               where i.Name.StartsWith(ch)
                               select i;

            foreach (var item in search_query)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }
        public static void ContainSearch(string ch)
        {
            var search_query = from i in employees
                               where i.Name.Contains(ch)
                               select i;

            foreach (var item in search_query)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Designation}");
            }
        }

    }
}