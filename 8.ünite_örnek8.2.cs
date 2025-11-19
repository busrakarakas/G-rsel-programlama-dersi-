using System;

class InitArray
{
   static void Main()
   {
      // create the space for array and initialize to default zeros
      int[] array = new int[5]; // array contains 5 int elements

      Console.WriteLine($"{"Index"}{"Value",8}"); // headings

      // output each array element's value                            
      for (int counter = 0; counter < array.Length; ++counter)
      {
         Console.WriteLine($"{counter,5}{array[counter],8}");
      }
   }
} 
