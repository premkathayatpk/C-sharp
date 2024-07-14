using System;
class ArraySum
{
  static void Main(){
    Console.Write("Enter a number: ");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] arr=new int[n];
    int sum=0;
Console.WriteLine("Enter ${n} numbers: ");
for(int i=0;i<n;i++){
  arr[i]=int.Parse(Console.ReadLine());
  sum+=arr[i];
}

Console.WriteLine("Sum of ${n} numbers is "+sum);
  }
}