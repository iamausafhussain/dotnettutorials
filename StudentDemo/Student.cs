namespace StudentDemo
{
    public class Student
    {
        static int id;
        static string name, city, address;

        /*public Student() { }
        public Student(int id, string name, string city, string address)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.address = address;
        }

        public void showDetails()
        {
            Console.WriteLine($"\nStudent ID: {this.id}");
            Console.WriteLine($"Student Name: {this.name}");
            Console.WriteLine($"City: {this.city}");
            Console.WriteLine($"Address: {this.address}");
        }*/

        public delegate void Del_set(int id, string name, string city, string address);

        public delegate void Del_get();

        public static void setStudent(int student_id, string student_name, string student_city, string student_address)
        {
            id = student_id;
            name = student_name;
            city = student_city;
            address = student_address;
        }

        public static void getStudent()
        {
            Console.WriteLine($"\nStudent ID: {id}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
