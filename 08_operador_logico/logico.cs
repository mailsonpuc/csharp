using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero1 = 10;
      int numero2 = 5;

      //-------------------------------------------------------------
      Console.WriteLine(numero1 < 5 && numero2 < 9 );   //AND
      //-------------------------------------------------------------
      


      //-------------------------------------------------------------
      Console.WriteLine(numero1 < 5 || numero2 < 9 );   //OR 
      //-------------------------------------------------------------
     
     
     
      //-------------------------------------------------------------
      Console.WriteLine(!(numero1 < 5 && numero2 < 9)); //NOT
      //-------------------------------------------------------------




    }
  }
}