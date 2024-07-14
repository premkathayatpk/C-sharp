using System;
class Employee{
  string name;
  string address;
  int age;
  public void SetName(string name){
    this.name=name;
  }
    public void SetAddress(string address){
    this.address=address;
  }
    public void SetAge(int age){
    this.age=age;
  }
  public string GetName(){
    return name;
  }
  public string GetAddress(){
    return address;
  }
  public int GetAge(){
    return age;
  }
}
class GetterSetter{
  static void Main(){
    Employee e=new Employee();
    e.SetName("Prem");
    e.SetAddress("Ktm");
    e.SetAge(22);
    Console.WriteLine(e.GetName() +" "+ e.GetAddress() +" "+ e.GetAge());
  }
}