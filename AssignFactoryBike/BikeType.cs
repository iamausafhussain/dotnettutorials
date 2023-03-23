namespace AssignFactoryBike
{
    public class YellowBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Create Engine : Yellow Bike");
        }

        public override void CreateChassis()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Create Engine : Yellow Bike");
        }
    }

    public class BlueBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create Engine : Blue Bike");
        }

        public override void CreateChassis()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create Engine : Blue Bike");
        }
    }
    public class RedBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Create Engine : Red Bike");
        }

        public override void CreateChassis()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Create Engine : Red Bike");
        }
    }
}
