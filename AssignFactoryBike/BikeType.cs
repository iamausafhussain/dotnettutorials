namespace AssignFactoryBike
{
    public class YellowBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Create Engine : Yellow Bike");
        }

        public override void CreateChassis()
        {
            Console.WriteLine("Create Engine : Yellow Bike");
        }
    }

    public class BlueBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Create Engine : Blue Bike");
        }

        public override void CreateChassis()
        {
            Console.WriteLine("Create Engine : Blue Bike");
        }
    }
    public class RedBike : AbsBike
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Create Engine : Red Bike");
        }

        public override void CreateChassis()
        {
            Console.WriteLine("Create Engine : Red Bike");
        }
    }
}
