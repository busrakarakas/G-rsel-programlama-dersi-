using System;
 
  class Mystery2
  {
    public static void Main()
    {
       int number = 50;
       while (number >= 40)
       {
          Console.WriteLine(number * 100/50 > 90? "A*" : "B");
          --number;
       } 
   }
  }
