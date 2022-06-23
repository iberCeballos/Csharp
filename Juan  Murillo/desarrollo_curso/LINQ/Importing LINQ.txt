using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
  
      var shortHeroes = from h in heroes
                        where h.Length < 8
                        select h;

      // Printing...
      Console.WriteLine("Your short heroes are...");
      
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }
    }
  }
}
