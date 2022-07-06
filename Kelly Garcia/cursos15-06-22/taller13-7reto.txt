using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Forest.ForestsCreated);
      Forest f = new Forest("Congo", "Tropical");
      Forest r = new Forest("Rendlesham");
      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}
