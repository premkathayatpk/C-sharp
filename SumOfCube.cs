using System;
class SumOfCube
{
  static void Main(){
    double a,b,c;
    Console.WriteLine("Enter three Numbers: ");
    a=Convert.ToDouble(Console.ReadLine());
    b=Convert.ToDouble(Console.ReadLine());
    c=Convert.ToDouble(Console.ReadLine());

    double sum=(a*a*a)+(b*b*b)+(c*c*c);
    Console.WriteLine("Sum of Cube of 3 num is "+sum);
  }
}