namespace BuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer obj = new SystemBuilder().setOsName("Windows OS").myPc();
            Computer obj2 = new SystemBuilder()
                .setOsName("Mac OS")
                .setRamSize(8)
                .setHddSize(256)
                .setGraphics("4")
                .setDisplay("16 Inch")
                .myPc();
            obj.DisplayDetails();
            obj2.DisplayDetails();
        }
    }
}