using System;
class FunctionOE
{
  static void check(int n){
    if(n%2==0){
      Console.WriteLine("Even");
    }
    else{
      Console.WriteLine("ODD");
    }
  }
  static void Main(){
    Console.WriteLine("Enter a num: ");
    int n=Convert.ToInt32(Console.ReadLine());
    check(n);

  }
}