//
// Genislenmeye aciq ve deyisilmez class 
// 
public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    private readonly double width;
    private readonly double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

public class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return 3.14 * radius * radius;
    }



}
public class OCP_Prinsip
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Duzbucaqli sahesi {rectangle.Area()}");
        Shape circle = new Circle(7);
        Console.WriteLine($"Daira sahesi {rectangle.Area()} ");

    }
}
