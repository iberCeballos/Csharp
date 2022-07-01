using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      
      citiesList.Add("New York City");
      
      foreach (string city in citiesList)
      {
        Console.WriteLine($"Welcome to...{city}!");
      }
    }
  }
}
