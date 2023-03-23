namespace AssignFacadeMobile
{
    internal class Iphone : IMobileShop
    {
        public Iphone()
        {
            ModelNumber();
            Price();
        }
        public void ModelNumber()
        {
            Console.WriteLine("ME1234123");
        }
        public void Price()
        {
            Console.WriteLine("89999");
        }
    }
}
