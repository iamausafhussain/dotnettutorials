namespace BurgerMain
{
    internal class Burger
    {
        private string bread;
        private string patty;
        private string veggies;
        private string sauces;
        private string extraCheese;

        public Burger(string bread, string patty, string veggies, string sauces, string extraCheese)
        {
            if (bread == null)
            {
                this.bread = "bread";
            }
            else
            {
                this.bread = bread;
            }
            if (patty == null)
            {
                this.patty = "veggies";
            }
            else
            {
                this.patty = patty;
            }
            if (veggies == null)
            {
                this.veggies = "No";
            }
            else
            {
                this.veggies = veggies;
            }
            if (sauces == null)
            {
                this.sauces = "No";
            }
            else
            {
                this.sauces = sauces;
            }
            if (extraCheese == null)
            {
                this.extraCheese = "No";
            }
            else
            {
                this.extraCheese = extraCheese;
            }
        }

        public void DisplayBurger()
        {
            Console.WriteLine($"Bread: {this.bread}\n" +
                $"Patty: {this.patty}\n" +
                $"Veggies: {this.veggies}\n" +
                $"Sauces: {this.sauces}\n" +
                $"Extra Cheese: {this.extraCheese}\n");
        }
    }
}
