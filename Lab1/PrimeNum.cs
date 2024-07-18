using System;
class PrimeNum{
  static void Main(){
    int num;
    for(num=100;num<=200;num++){
      if(isPrime(num)){
        Console.Write(num+" ");
      }
        }
      }
      static bool isPrime(int n){
      if(n<=1){
        return false;
      }
      for(int i=2;i<n;i++){
        if(n%i==0){
          return false;
        }
      }
      return true;
      }
    }
   
    
  
