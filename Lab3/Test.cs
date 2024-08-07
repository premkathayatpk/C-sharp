using System;
class Person{
  string firstName;
  string lastName;
  int age;
  public Person(string firstName,string lastName,int age){
    this.firstName=firstName;
    this.lastName=lastName;
    this.age=age;
  }
  public virtual void showInfo(){
        Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName + " Age: " + age);
  }
}
class Student:Person{
  string faculty;
   public Student(string firstName, string lastName, int age, string faculty) 
        : base(firstName, lastName, age)
    {
        this.faculty = faculty;
    }
  public override void showInfo(){
    base.showInfo();
    Console.WriteLine("Faculty: "+faculty);
  }
}
class Teacher:Person{
  double salary;
   public Teacher(string firstName, string lastName, int age, double salary) 
        : base(firstName, lastName, age)
    {
        this.salary = salary;
    }
  public override void showInfo(){
    base.showInfo();
    Console.WriteLine("Salary: "+salary);
  }
}
class Test{
  static void Main(){
    Person s=new Student("Ram", "joshi",22,"BCA");
    s.showInfo();
    Person t=new Teacher("Hari","Bhatta",45,30000);
    t.showInfo();
  }
}