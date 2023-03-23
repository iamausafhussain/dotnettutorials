namespace AssignFactoryBike
{
    internal class Factory
    {
        public static AbsBike GetInstance(string objectType)
        {
            AbsBike instance = null;
            if (objectType == "yellow")
            {
                instance = new YellowBike();
            }
            else if (objectType == "blue")
            {
                instance = new BlueBike();
            }
            else if (objectType == "red")
            {
                instance = new RedBike();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            return instance;
        }
    }
}
