namespace AssignFactoryBike
{
    internal class Factory
    {
        public static AbsBike GetInstance(string objectType)
        {
            AbsBike instance = null;
            if (objectType.ToLower() == "yellow")
            {
                instance = new YellowBike();`
            }
            else if (objectType.ToLower() == "blue")
            {
                instance = new BlueBike();
            }
            else if (objectType.ToLower() == "red")
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
