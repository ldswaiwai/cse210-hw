using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 5);
        //Console.WriteLine($"The color of the square is {square.GetColor()}. \nThe area of the square is {square.GetArea()}cm\u00B2.");

        Rectangle rectangle = new Rectangle("yellow", 7,5);
        //Console.WriteLine($"The color of the rectangle is {rectangle.GetColor()}. \nThe area of the rectangle is {rectangle.GetArea()}cm\u00B2.");

        Circle circle = new Circle("green", 2.5);
        //Console.WriteLine($"The color of the circle is {circle.GetColor()}. \nThe area of the circle is {circle.GetArea():F2} cm\u00B2");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shp in shapes)
        {
            Console.WriteLine($"The {shp.GetColor()} shape has an area of {shp.GetArea():F2} cm\u00B2");
        }

    }

}