namespace StudentDemo
{
    public class Student
    {
        int id;
        string name, city, address;

        public Student() { }
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
        }
    }
}
