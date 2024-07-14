using System;
class LargestAndSecLargest
{
  static void Main()
  {
    int i,n;
    Console.WriteLine("Enter a num: ");
    n=Convert.ToInt32(Console.ReadLine());
    int[] a=new int[n];
    Console.WriteLine("Enter "+n+" numbers: ");
    for(i=0;i<n;i++){
      a[i]=int.Parse(Console.ReadLine());
    }
    Array.Sort(a);
    //Array.Reverse(a);
    Console.WriteLine("Largest num is "+ a[n-1]+" Second Largest num is "+a[i-2]);
  }
}