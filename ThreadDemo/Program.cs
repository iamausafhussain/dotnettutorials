namespace ThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fun1();
            Fun2();
            Fun3();
            Fun4();
            Console.ReadLine();
        }
        public async static void Fun1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("This is my Fun1() Calling!");
            });
        }
        public static async void Fun2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("This is my Fun2() Calling!");
            });
        }
        public static async void Fun3()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("This is my Fun3() Calling!");
            });
        }
        public static async void Fun4()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("This is my Fun4() Calling!");
            });
        }
    }
}