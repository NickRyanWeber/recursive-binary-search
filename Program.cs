using System;

namespace recursive_binary_search
{
  class Program
  {
    static void Count(int x)
    {
      if (x == 10)
      {
        return;
      }
      else
      {
        Console.WriteLine(x);
        Count(x + 1);
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Count(0);
    }
  }
}
