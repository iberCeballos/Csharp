using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
			Dissertation diss = new Dissertation();
      Diary dy = new Diary();
      
      Book bdiss = diss;
      Book bdy = dy;
    }
  }
}
