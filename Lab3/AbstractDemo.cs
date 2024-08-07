using System;

abstract class Shape
{
  protected double dim1;
  protected double dim2;

  public Shape(double d1, double d2)
  {
    dim1 = d1;
    dim2 = d2;
  }

  public abstract double Area();
}

class Rectangle : Shape
{
  public Rectangle(double width, double height) : base(width, height) { }

  public override double Area()
  {
    return dim1 * dim2;
  }
}

class Triangle : Shape
{
  public Triangle(double baseLength, double height) : base(baseLength, height) { }

  public override double Area()
  {
    return 0.5 * dim1 * dim2;
  }
}

class AbstractDemo
{
  static void Main()
  {
    Shape rect = new Rectangle(10.0, 5.0);
    Console.WriteLine("Area of Rectangle: " + rect.Area());

    Shape tri = new Triangle(10.0, 5.0);
    Console.WriteLine("Area of Triangle: " + tri.Area());
  }
}
