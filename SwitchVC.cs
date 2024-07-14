using System;
class SwitchVC
{
  static void Main(){
    Console.WriteLine("Enter a Char: ");
    char c=Convert.ToChar(Console.ReadLine());
    switch(c){
      case 'a':
      Console.WriteLine("Vowel");
      break;
       case 'e':
      Console.WriteLine("Vowel");
      break;
       case 'i':
      Console.WriteLine("Vowel");
      break;
       case 'o':
      Console.WriteLine("Vowel");
      break;
       case 'u':
      Console.WriteLine("Vowel");
      break;
    
 default:
       Console.WriteLine("Consolant");
     break;

    }
  }
}