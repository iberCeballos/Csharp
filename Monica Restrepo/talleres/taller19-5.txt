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

      var heroesWithI = from hero in heroes
        where hero.Contains("i")
        select hero;
      
      var underscored = from hero in heroes
        select hero.Replace(' ', '_');
    }
  }
}
