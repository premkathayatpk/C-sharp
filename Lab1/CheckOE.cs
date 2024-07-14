using System;
class CheckOE
{
  static void Main(){
    Console.Write("Enter a Number: ");
    int num= Convert.ToInt32(Console.ReadLine());

    if(num%2==0){
      Console.WriteLine(num + " is Even.");
    }
    else{
      Console.WriteLine(num +" is Odd.");
    }
  }
}