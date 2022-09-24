namespace FizzzB{
using System;
class MainClass 
 {
   static void FizzBuzz(int num) 
  {
     // code goes here 
    for (int i=1; i<num+1; i++ )
    {
       if (i%3==0) 
       {
         Console.Write("Fizz");
       }
      if (i%5==0)
       {
       Console.Write("Buzz") ;
       }
       if (i%3!=0&&i%5!=0&&i%15!=0)
       {
         Console.Write(i);
       }
       Console.Write(" ");
     }
  } 
  static void Main() {  
    // keep this function call here
    int num=Convert.ToInt32(Console.ReadLine());
    FizzBuzz(num);
    } 
  }
 }