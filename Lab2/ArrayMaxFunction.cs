using System;
class ArrayMaxFunction{
  static int max(int[] arr,int n){
    Array.Sort(arr);
    return arr[n-1];

  }
  static void Main(){
    Console.Write("Enter a number: ");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] arr=new int[n];
Console.WriteLine("Enter "+n+" numbers: ");
for(int i=0;i<n;i++){
  arr[i]=int.Parse(Console.ReadLine());
}

Console.WriteLine("Max  value is "+max(arr,n));

  }
}