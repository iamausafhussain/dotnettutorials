namespace AssignFactoryBike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Object Type: ");
            string type = Console.ReadLine();
            AbsBike instance = Factory.GetInstance(type);
            if (instance != null)
            {
                instance.CreateEngine();
                instance.CreateChassis();
            }
        }
    }
}