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

      var heroesWithI = heroes.Where(h => h.Contains("i")); 
            
      foreach (var hero in heroesWithI)
      {
        Console.WriteLine(hero);
      }
    }
  }
}
