using System;
class SwitchArithmatic
{
  static void Main(){
    double result=0;
    Console.WriteLine("Enter two Numbers : ");
      double a=Convert.ToDouble(Console.ReadLine());
      double b=Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Enter 1 for Add \n Enter 2 for Subtraction \n Enter 3 for Multiplication \n Enter 4 for Divide : ");
    int n=Convert.ToInt32(Console.ReadLine());
    switch(n){
      case 1:
      result =a+b;
        break;
       case 2:
result = a-b;
      break;
       case 3:
  result=a*b;
        break;
       case 4:
         result=a/b;

      break;
     
    
 default:
       Console.WriteLine("Invalid Choice Please Chose(1-4) ");
     break;

    }
    Console.WriteLine("Result is "+result);
  }
}