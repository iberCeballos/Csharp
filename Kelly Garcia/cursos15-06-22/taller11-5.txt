using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };
      
      foreach (string website in websites)
      { 
        Console.WriteLine(website); 
      }
    }
  }
}
