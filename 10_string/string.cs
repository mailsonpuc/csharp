using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
 
 
      string txt = "Hello Brazil";

      //--------------------------------------------------------------------
      Console.WriteLine(txt.Length);    //Length 
      //--------------------------------------------------------------------
     
     
     
      //---------------------------------------------------------------------
      Console.WriteLine(txt.ToUpper()); //ToUpper() 
      //---------------------------------------------------------------------

     
     
      //----------------------------------------------------------------------
      Console.WriteLine(txt.ToLower()); // ToLower() 
      //----------------------------------------------------------------------


 

      //-----------------------------------------------------------------------
      string firstName = "Maria ";
      string lastName = "Silva";
      string name = firstName + lastName; //concatenaçãõ
      Console.WriteLine(name);
      //-----------------------------------------------------------------------



      //------------------------------------------------------------------------
      string firstName2 = "Ana ";
      string lastName3 = "Julia";
      string name4 = string.Concat(firstName2, lastName3); //Concat(str1 ,str2)
      Console.WriteLine(name4);
      //-------------------------------------------------------------------------



      //-------------------------------------------------------------------------
      string primeiroNome = "Mailson";
      string segundoNome  = "Puc";

      string nomeCompleto = $"Nome Completo {primeiroNome} {segundoNome}"; //interpolation
      
      Console.WriteLine(nomeCompleto);
      //-------------------------------------------------------------------------



      //-------------------------------------------------------------------------
      string myString = "Hello";
      Console.WriteLine(myString[0]); //Acess [0}
      //-------------------------------------------------------------------------



      //-------------------------------------------------------------------------
      string myString2 = "Hello";
      Console.WriteLine(myString2.IndexOf("o")); //Procura Posição IndexOf
      //-------------------------------------------------------------------------


     
      //-------------------------------------------------------------------------
      // Full name
      string name44 = "Maria Silva";
     // Location of the letter S
     int charPos = name44.IndexOf("S");
     // Get last name
     string nomeCompleto44 = name4.Substring(charPos);   //SUbstring()
     // Print the result
     Console.WriteLine(nomeCompleto44);
      //-------------------------------------------------------------------------






    }
  }
}
