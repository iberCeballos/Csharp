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
      
      double time = marathons[1];
      
      Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

    }
  }
}
