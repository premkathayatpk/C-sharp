using System;
class Area{
  int length;
  int breadth;
  public Area(int length,int breadth){
    this.length=length;
    this.breadth=breadth;
  }
  public int GetArea(){
    return length*breadth;
  }
}
class Constructor{
static void Main(){
  Console.WriteLine("Enter length and breadth of Rectangle: ");
  int l=int.Parse(Console.ReadLine());
  int b=int.Parse(Console.ReadLine());
  Area a=new Area(l,b);
 Console.WriteLine("Area is "+ a.GetArea());
}
}