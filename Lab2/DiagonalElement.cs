using System;
class DiagonalElement
{
  static void Main(){
    int i,j;
    int[,] arr=new int[3,3];
    Console.WriteLine("Enter 9 numbers: ");
    for(i=0;i<3;i++){
      for(j=0;j<3;j++){
        arr[i,j]=int.Parse(Console.ReadLine());
      }
    }
    Console.WriteLine("Given Matrix is : ");
    for(i=0;i<3;i++){
      for(j=0;j<3;j++){
        Console.Write(arr[i,j]+" ");
       
        }
        Console.WriteLine();
    }
        Console.WriteLine("Diagonal of  Matrix are : ");
        for(i=0;i<3;i++){
      for(j=0;j<3;j++){
         if(i==j){
Console.WriteLine(arr[i,j]) ;     
        } 
      }
  }
}
}