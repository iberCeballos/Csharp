using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      // Method syntax
      var result = heroes.Select(h => $"Introducing...{h}!");
      
      // Query syntax
      var result2 = from h in heroes
        where h.Contains(" ")
        select h.IndexOf(" ");
      
      // Printing...
      Console.WriteLine("'result': ");
      foreach (var v in result)
      {
        Console.WriteLine(v);
      }
      
      Console.WriteLine("\n'result2': ");
      foreach (var v in result2)
      {
        Console.WriteLine(v);
      }
    }
  }
}
