 using System;
 
  class TwoForLoops
  {
    static void Main()
    {
       for (int x = 4; x >= 1; --x)
       {
          for (int y = 5; y >= 1; --y)
          {
             Console.Write($"\t{y}");
          }
 
       Console.WriteLine();
       } 
    }
  }
