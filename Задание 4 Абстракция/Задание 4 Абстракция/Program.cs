var rectangle = new Rectangle {Width = 5, Height = 4};
var circle = new Circle { Radious = 10 };
circle.GetArea();
rectangle.GetArea();

abstract class Shape 
{
    public abstract void GetArea();
}
class  Circle : Shape
{
    public double Radious { get; set; }
    public override void GetArea()
    {
        Console.WriteLine($"Площадь круга: {Radious * Radious * 3.14}");
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override void GetArea()
    { 
        Console.WriteLine($"Площадь прямоугольника: {Width * Height}"); 
    }
}