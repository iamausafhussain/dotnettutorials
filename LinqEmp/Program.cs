namespace LinqEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter id to find");
            int find_id = Convert.ToInt32(Console.ReadLine());
            Program.SelectOdd(find_id);*/

            /*Console.WriteLine("Enter name to find");
            string find_name = Console.ReadLine();
            Program.SelectOdd(find_name);*/

            Console.WriteLine("Sort Ascending");
            Program.Sort();


            /*var data_emp = (from emp in employees
                            select emp);*/


            //using IQueryable
            /*IQueryable<Employee> queryableEmp = employees.AsQueryable();

            var query = from emp in queryableEmp
                        where emp.Address == "BBSR" && emp.Id > 1
                        select emp;*/

            // retrive specific attribute
            /*var data_query = (from i in employees
                              select new Employee()
                              {
                                  Id = i.Id,
                                  Name = i.Name
                              }).ToList();*/


            /*foreach (var item in query)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Address}");
            }*/

            /*---------------------------------------*/

            // copy data
            /*var data_query = (from i in employees
                              select new EmpNew()
                              {
                                  UserId = i.Id,
                                  UserName = i.Name,
                                  City = i.Address
                              }).ToList();*/
        }

        public static void SelectOdd(string n)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1, Name ="Aruhi", Address="PUI"},
                new Employee {Id = 2, Name ="Ausaf", Address="BBSR"},
                new Employee {Id = 3, Name ="Yasmin", Address="CTC"},
                new Employee {Id = 4, Name ="Gourav", Address="BGLR"},
            };
            var custom_emp = employees.Where(i => i.Name == n)
                .Select(i => i);

            foreach (var item in custom_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Address}");
            }
        }

        public static void Sort()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 4, Name ="Aruhi", Address="PUI"},
                new Employee {Id = 2, Name ="Ausaf", Address="BBSR"},
                new Employee {Id = 1, Name ="Yasmin", Address="CTC"},
                new Employee {Id = 3, Name ="Gourav", Address="BGLR"},
            };
            var sort_emp = employees.OrderBy(i => i.Id);

            foreach (var item in sort_emp)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Address: {item.Address}");
            }
        }
    }
}