namespace AssignFacadeMobile
{
    internal class Shopkeeper
    {
        public Shopkeeper()
        {
            IphoneSale();
            SamsungSale();
            BlackberrySale();
        }

        public void IphoneSale()
        {
            Iphone iphone = new Iphone();
        }
        public void SamsungSale()
        {
            Samsung samsung = new Samsung();
        }
        public void BlackberrySale()
        {
            Blackberry blackberry = new Blackberry();
        }
    }
}
