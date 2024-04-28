using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Nome de usuario:");
      string userName = Console.ReadLine();



       Console.WriteLine("Idade");
       int idade = Convert.ToInt32(Console.ReadLine());
      
   
      Console.WriteLine($"Nome: {userName} idade {idade}");
    }
  }
}

