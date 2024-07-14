using System;
class SumOfNum
{
  static void Main(){
    Console.Write("Enter a number: ");
    int num=Convert.ToInt32(Console.ReadLine());

int i;
int sum=0;
    for(i=1;i<=num;i++){
sum+=i;
    }
    Console.WriteLine("Sum of first "+ num +" is: " + sum);
  }
}