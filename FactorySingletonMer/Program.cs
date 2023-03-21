namespace FactorySingletonMer
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
                obj.Display();
            }
            IFactory obj2 = Factory.getObject(typeOfObject);
            if (obj2 != null)
            {
                obj2.Display();
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
                factory = SingletonClass.GetInstance;
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
        public void Display();
    }
}