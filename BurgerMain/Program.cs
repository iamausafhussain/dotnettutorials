namespace BurgerMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burger vegburger = SystemBurgerBuilder.GetBurgerBuilderInstance
                .addBread("Crust")
                .addPatty("Veggie")
                .addCheese("Yes")
                .Build();
            vegburger.DisplayBurger();

            Burger vegburgertwo = SystemBurgerBuilder.GetBurgerBuilderInstance
                .addBread("Crust")
                .addPatty("Veggie")
                .addCheese("Yes")
                .Build();
            vegburgertwo.DisplayBurger();
        }
    }
}