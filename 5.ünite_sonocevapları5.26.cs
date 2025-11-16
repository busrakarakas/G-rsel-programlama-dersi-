  using System;
 
  class Mystery3
  {
    static void Main()
    {
       int row = 10;
       int column;
       while (row >= 1)
       {
          column = 1;
 
          while (column <= 10)
          {
             Console.Write(row % 2 == 1 ? "<" : ">");
             ++column;
          } 

          --row;
          Console.WriteLine();
       } 
     }
  }
