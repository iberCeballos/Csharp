using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      /* es codigo lo que hace es que esta preguntado cuantos años tiene la persona que lo ejecuta */
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}