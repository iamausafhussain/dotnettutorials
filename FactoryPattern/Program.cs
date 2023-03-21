namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Object Type: ");
            string typeOfObject = Console.ReadLine();
            IFactory obj = Factory.getObject(typeOfObject);
            if (obj != null)
            {
                Console.WriteLine(obj.getName());
            }
        }
    }

    class Factory
    {
        public static IFactory getObject(string typeofObject)
        {
            IFactory factory = null;
            if (typeofObject.ToLower() == "student")
            {
                factory = new Student();
            }
            else if (typeofObject.ToLower() == "teacher")
            {
                factory = new Teacher();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            return factory;
        }
    }

    interface IFactory
    {
        string getName();
        string getFatherName();
    }

    public class Teacher : IFactory
    {
        public Teacher()
        {
            Console.WriteLine("This is default constructor");
        }
        public Teacher(int x)
        {
            Console.WriteLine($"Teacher age: {x}");
        }
        public string getName()
        {
            return "This is Teacher Name";
        }

        public string getFatherName()
        {
            return "This is Teacher Father Name";
        }
    }

    public class Student : IFactory
    {
        public string getName()
        {
            return "This is Student Name";
        }

        public string getFatherName()
        {
            return "This is Student Father Name";
        }
    }
}