using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {

      int numero1 = 10, numero2 = 2;

      float numero3 = -4.7f;


      //-----------------------------------------------------------------------------
      Console.WriteLine($"Numero Maior {Math.Max(numero1, numero2)} ");  // Math.max
      //-----------------------------------------------------------------------------



      //-----------------------------------------------------------------------------
      Console.WriteLine($"Numero Menor {Math.Min(numero1, numero2)} ");  // Math.Min
      //-----------------------------------------------------------------------------



      //-----------------------------------------------------------------------------
      Console.WriteLine($"raiz quadrada {Math.Sqrt(numero1)} ");         // Math.Sqrt
      //-----------------------------------------------------------------------------
    


      //-----------------------------------------------------------------------------
      Console.WriteLine($"Abs {Math.Abs(numero3)} ");                    //Math.Abs
      //-----------------------------------------------------------------------------




      //------------------------------------------------------------------------------
      Console.WriteLine($"Round {Math.Round(9.99)} ");                   // Math.Round
      //------------------------------------------------------------------------------


    }
  }
}
