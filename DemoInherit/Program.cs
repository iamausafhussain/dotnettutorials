namespace DemoInherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.show();
            obj.show2();
            B obj2 = new B();
            obj2.show();
            obj2.show2();
            C obj3 = new C();

            obj3.show2();
        }
    }
}

public class A
{
    private int x = 100;
    private int y = 200;

    public virtual void show()
    {
        Console.WriteLine($"The number x is {x}");
    }

    public virtual void show2()
    {
        Console.WriteLine($"The number y is {this.y}");
    }
}

public class B : A
{
    public sealed override void show()
    {
        Console.WriteLine($"The derived number is {this.x}");
    }

    public override void show2()
    {
        Console.WriteLine($"The number y is {this.y}");
    }
}

public class C : B
{
    /*public override void show()
    {
        Console.WriteLine($"The derived number is {this.x}");
    }*/

    public override void show2()
    {
        Console.WriteLine($"The number y is {this.y}");
    }


}