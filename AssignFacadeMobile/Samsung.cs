namespace AssignFacadeMobile
{
    internal class Samsung : IMobileShop
    {
        public Samsung()
        {
            ModelNumber();
            Price();
        }
        public void ModelNumber()
        {
            Console.WriteLine("293478019243");
        }
        public void Price()
        {
            Console.WriteLine("47999");
        }
    }
}
