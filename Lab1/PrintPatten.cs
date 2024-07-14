using System;
class PrintPatten
{
  static void Main(){
    int i,j;
    for(i=0;i<5;i++){
      for(j=0;j<=i;j++){
        Console.Write("* ");
      }
Console.WriteLine();
    }
  }
}