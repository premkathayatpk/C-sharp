using System;
class Employee{
  string name;
   int age;
   int salary;

  public void SetName(string name){
    this.name=name;
  }
 
    public void SetAge(int age){
    this.age=age;
  }
  public void SetSalary(int salary){
    this.salary=salary;
  }
  public string GetName(){
    return name;
  }
 
  public int GetAge(){
    return age;
  }
  public int GetSalary(){
    return salary;
  }
}
class GetterSetter{
  static void Main(){
    Employee e=new Employee();
    e.SetName("Ram");
    e.SetAge(22);
    e.SetSalary(20000);
    Console.WriteLine(e.GetName() +" "+ e.GetAge()+" "+e.GetSalary());
  }
}