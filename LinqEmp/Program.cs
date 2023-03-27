namespace LinqEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1, Name ="Aruhi", Address="PUI"},
                new Employee {Id = 2, Name ="Ausaf", Address="BBSR"},
                new Employee {Id = 3, Name ="Yasmin", Address="CTC"},
                new Employee {Id = 4, Name ="Gourav", Address="BGLR"},
            };

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
            var data_query = (from i in employees
                              select new EmpNew()
                              {
                                  UserId = i.Id,
                                  UserName = i.Name,
                                  City = i.Address
                              }).ToList();
            foreach (var item in data_query)
            {
                Console.WriteLine(item.UserId);
            }
        }
    }
}