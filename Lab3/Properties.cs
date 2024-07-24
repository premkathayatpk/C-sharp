using System;
class Student{
  public string Name{
    get;
    set;
  }
   public int Age{
    get;
    set;
   }
   public string Faculty{
    get;
    set;
   }
}
class Properties{
  static void Main(){
    Student s=new Student();
    s.Name="Ram";
    s.Age=22;
    s.Faculty="BCA";
    Console.WriteLine(s.Name+" "+s.Age+" "+s.Faculty);
  }
}