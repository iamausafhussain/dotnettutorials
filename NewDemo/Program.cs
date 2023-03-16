namespace NewDemo
{
    public interface Color
    {
        public void getColor();
    }
    public abstract class Shape
    {
        public int length;
        public int breadth;

        public abstract int getArea(int length, int breadth);

        public virtual int getPerimeter(int length, int breadth)
        {
            return 2 * (length + breadth);
        }
    }

    public class Rectangle : Shape, Color
    {
        public override int getArea(int length, int breadth)
        {
            return length * breadth;
        }

        public override int getPerimeter(int length, int breadth)
        {
            return 4 * length;
        }

        public void getColor()
        {
            Console.WriteLine("The color is blue");
        }
    }

    public class Square : Shape, Color
    {
        public override int getArea(int length, int breadth)
        {
            return length * length;
        }

        public override int getPerimeter(int length, int breadth)
        {
            return 4 * length;
        }

        public void getColor()
        {
            Console.WriteLine("The color is red");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            int area = rectangle.getArea(10, 10);
            int perimeter = rectangle.getPerimeter(8, 8);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
            rectangle.getColor();

            Square square = new Square();
            int sq_area = square.getArea(10, 10);
            int sq_perimeter = square.getPerimeter(8, 8);
            Console.WriteLine($"Area: {sq_area}");
            Console.WriteLine($"Perimeter: {sq_perimeter}");
            square.getColor();

        }
    }


}

