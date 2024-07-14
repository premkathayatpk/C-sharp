using System;
class AreaOFCircle
{
  static void Main(){
    Console.Write("Enter Radius: ");
    double r= Convert.ToDouble(Console.ReadLine());
    double area= Math.PI *r*r;
    Console.WriteLine("Area of Circle is "+area);
  }
}