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
      
      List<double> topMarathons = marathons.GetRange(0,3);
      
      foreach (double d in topMarathons)
      {
        Console.WriteLine(d);
      }
    }
  }
}
