using System;
class SortArray
{
  static void Main(){
    int i;
    Console.Write("Enter a number: ");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] arr=new int[n];
    Console.WriteLine("Enter "+n+" number: ");
    for(i=0;i<n;i++){
      arr[i]=int.Parse(Console.ReadLine());
    
    }
    Array.Sort(arr);
    Console.WriteLine("Sorting array is ");
    for(i=0;i<n;i++){
     Console.WriteLine(arr[i]);
    }
  }
}