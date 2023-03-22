namespace HomeMainAppBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Home house_one = SystemHomeBuilder.GetBuilderInstance
                .SetHomeName("Mannat")
                .SetHomeType("Apartment")
                .SetBhk(32)
                .SetStorey(14)
                .SetExtraSpecs("Pool")
                .BuildMyHome();

            Home house_two = SystemHomeBuilder.GetBuilderInstance
                .SetHomeName("Antillia")
                .SetHomeType("Bunglow")
                .SetBhk(112)
                .SetStorey(24)
                .SetExtraSpecs("Underground Car Parking")
                .BuildMyHome();
            house_one.DisplayHome();
            house_two.DisplayHome();
        }
    }
}