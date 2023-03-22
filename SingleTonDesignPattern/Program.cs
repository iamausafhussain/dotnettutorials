namespace SingleTonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SingletonClass one = new SingletonClass();
            one.Display("Hello from First Client");

            SingletonClass two = new SingletonClass();
            two.Display("Hello from Second Client");

            SingletonClass three = new SingletonClass();
            three.Display("Hello from Second Client");*/

            SingletonClass singletonOne = SingletonClass.GetInstance;
            singletonOne.Display("Hello from First Client");

            SingletonClass singletonTwo = SingletonClass.GetInstance;
            singletonTwo.Display("Hello from second Client");

            SingletonClass singletonThree = SingletonClass.GetInstance;
            singletonThree.Display("Hello from third Client");
        }
    }
}