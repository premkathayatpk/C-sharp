using System;
class Sum2x3
{
  static void Main()
  {
    int sum=0;
    int[,] a=new int[2,3]; 
    Console.WriteLine("Enter 6 numbers: ");
    for(int i=0;i<2;i++){
      for(int j=0;j<3;j++){
        a[i,j]=int.Parse(Console.ReadLine());
        sum+=a[i,j];
      }
    }
    Console.WriteLine("Sum of 2x3 array is "+sum);
  }
}