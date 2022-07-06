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

      // Separate statements
      var heroesWithC = heroes.Where(h => h.Contains("c"));
      var lowerHeroesWithC = heroesWithC.Select(h => h.ToLower());
    
      // Chained expressions
      var sameResult = heroes   
        .Select(h => h.ToLower())
        .Where(h => h.Contains("c"));
      
      foreach (var hero in sameResult)
      {
        Console.WriteLine(hero);
      }
    }
  }
}
