using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      
      Console.WriteLine(marathons.Count);
      
      marathons.Add(143.23);
      
      Console.WriteLine(marathons.Contains(143.23));
      
      Console.WriteLine(marathons.Count);

    }
  }
}
