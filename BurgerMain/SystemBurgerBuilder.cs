namespace BurgerMain
{
    internal sealed class SystemBurgerBuilder
    {
        private string bread;
        private string patty;
        private string veggies;
        private string sauces;
        private string extraCheese;

        private static SystemBurgerBuilder instance = null;
        public static SystemBurgerBuilder GetBurgerBuilderInstance
        {
            get
            {
                if (instance == null)
                    instance = new SystemBurgerBuilder();
                return instance;
            }
        }

        public SystemBurgerBuilder addBread(string bread)
        {
            this.bread = bread;
            return this;
        }
        public SystemBurgerBuilder addPatty(string patty)
        {
            this.patty = patty;
            return this;
        }
        public SystemBurgerBuilder addVeggies(string veggies)
        {
            this.veggies = veggies;
            return this;
        }
        public SystemBurgerBuilder addSauces(string sauces)
        {
            this.sauces = sauces;
            return this;
        }
        public SystemBurgerBuilder addCheese(string extraCheese)
        {
            this.extraCheese = extraCheese;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this.bread, this.patty, this.veggies, this.sauces, this.extraCheese);
        }
    }
}
