using System;
class SumJagged
{
  static void Main()
  {
    int[][] a=new int[3][];
    a[0]=new int[3];
    a[1]=new int[4];
    a[2]=new int[1];
    int sum=0;

    Console.WriteLine("Enter Array elements: ");
    for(int i=0;i<3;i++){
      for(int j=0;j<a[i].Length;j++){
        a[i][j]=int.Parse(Console.ReadLine());
        sum+=a[i][j];
      }
    }
    Console.WriteLine("Sum of Jagged array is "+sum);
  }
}