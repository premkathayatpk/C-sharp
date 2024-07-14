using System;
class SumArray
{
  static void Main(){
    int i;
    int[] a=new int[10];
    int sum=0;
    Console.WriteLine("Enter 10 numbers: ");
    for(i=0;i<10;i++){
      a[i]=int.Parse(Console.ReadLine());
      sum+=a[i];
    }
    Console.WriteLine("Sum of 10 Numbers is "+sum);
  }
}