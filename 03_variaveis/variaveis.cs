using System;

namespace App
{
   class Program
   {
      static void Main(string[] args)
      {
      
 //----------------------------------------------------------------
        //string
        string name = "Maria";   
        Console.WriteLine($"MINHA STRING {name}");

 //----------------------------------------------------------------
 



 //----------------------------------------------------------------
        //int
        int numero = 10;
        Console.WriteLine($"MEU INT {numero}");

 //----------------------------------------------------------------
 



 //----------------------------------------------------------------
        //double
        double numero_double = 5.99D;
        Console.WriteLine($"MEU DOUBLE {numero_double}");

 //----------------------------------------------------------------




 //----------------------------------------------------------------
       //meu long
        long myNum = 15000000000L;
        Console.WriteLine($"meu long {myNum}");

 //----------------------------------------------------------------




 //----------------------------------------------------------------
        //meu float
        float meu_float = 5.75F;
        Console.WriteLine($"Meu Float {meu_float}");
 //----------------------------------------------------------------




 //----------------------------------------------------------------
        //char
        char letra = 'M';
        Console.WriteLine($"MEU CHAR {letra}");

 //----------------------------------------------------------------




 //----------------------------------------------------------------
        //bool
        bool meu_bool = true;
        Console.WriteLine($"MEU BOOL {meu_bool}");
 //----------------------------------------------------------------




 //----------------------------------------------------------------
       //const
       const int nao_pode_altera = 20;
       Console.WriteLine($"MINHA CONSTANT {nao_pode_altera}");
//----------------------------------------------------------------




//----------------------------------------------------------------      
       //cocatna com +
       string firstName = "Maria ";
       string lastName = "Silva";
       string fullName = firstName + lastName;
       Console.WriteLine($"concatenando com + {fullName}");
//----------------------------------------------------------------




//----------------------------------------------------------------
      //declara muitas variaveis
      int x = 5, y = 6, z = 50;
      Console.WriteLine($"Muitas variaveis { x + y + z }");

//----------------------------------------------------------------


      
      }
   }
}
