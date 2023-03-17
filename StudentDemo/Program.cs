namespace StudentDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            char ch;
            int choice;
            do
            {
                Console.WriteLine("\nPress\n1.Enter Student Details\n2.Show Student Details\n3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Student ID: ");
                        int student_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name: ");
                        string student_name = Console.ReadLine();
                        Console.WriteLine("Enter Student City:");
                        string student_city = Console.ReadLine();
                        Console.WriteLine("Enter Student Address:");
                        string student_address = Console.ReadLine();

                        student = new Student(student_id, student_name, student_city, student_address);

                        Console.WriteLine("\nDetails Successfully Saved!");

                        break;
                    case 2:
                        student.showDetails();
                        break;
                    case 3: return;
                }
                Console.WriteLine("\nPress y/Y to continue or Press any other key to Exit\n");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');
        }
    }
}