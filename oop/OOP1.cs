using System;
class Employee{
  string name;
  string address;
  int age;
  public void set(string name,string address,int age){
    this.name=name;
    this.address=address;
    this.age=age;
  }
  public void show(){
    Console.WriteLine(name+" "+address+" "+age);
  }
}
class OOP1{
  static void Main(){
    Employee e1=new Employee();
    e1.set("Prem","Ktm",22);
    e1.show();
        // Employee e2=new Employee();

    e1.set("Ram","Pok",23);
    e1.show();
  }
}