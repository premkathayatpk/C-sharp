using System;
class ReverseNum{
  static int reverse(int n){
    int rem, rev=0;
    while(n!=0){
       rem=n%10;
       rev=rem+rev*10;
       n=n/10;
    }
    return rev;
      
    }
  static void Main(){

  
    Console.WriteLine("Enter a num: ");
    int n=Convert.ToInt32(Console.ReadLine());
   int rev=reverse(n);
    Console.WriteLine("Reverse is "+rev );
  }
}