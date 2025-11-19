using System;

class ArrayReferenceTest
{
   static void Main()
   {
      // create and initialize firstArray
      int[] firstArray = { 1, 2, 3 };

      // copy the reference in variable firstArray
      int[] firstArrayCopy = firstArray;

      Console.WriteLine("Test passing firstArray reference by value");
      Console.Write(
         "Contents of firstArray before calling FirstDouble:\n\t");

      // display contents of firstArray
      foreach (var element in firstArray)
      {
         Console.Write($"{element} ");
      }

      // pass variable firstArray by value to FirstDouble
      FirstDouble(firstArray);

      Console.Write(
         "\nContents of firstArray after calling FirstDouble\n\t");

      // display contents of firstArray
      foreach (var element in firstArray)
      {
         Console.Write($"{element} ");
      }

      // test whether reference was changed by FirstDouble
      if (firstArray == firstArrayCopy)
      {
         Console.WriteLine("\n\nThe references refer to the same array");
      }
      else
      {
         Console.WriteLine(
            "\n\nThe references refer to different arrays");
      }

      // create and initialize secondArray
      int[] secondArray = { 1, 2, 3 };

      // copy the reference in variable secondArray
      int[] secondArrayCopy = secondArray;

      Console.WriteLine(
         "\nTest passing secondArray reference by reference");
      Console.Write(
         "Contents of secondArray before calling SecondDouble:\n\t");

      // display contents of secondArray before method call
      foreach (var element in secondArray)
      {
         Console.Write($"{element} ");
      }

      // pass variable secondArray by reference to SecondDouble
      SecondDouble(ref secondArray);

      Console.Write(
         "\nContents of secondArray after calling SecondDouble:\n\t");

      // display contents of secondArray after method call
      foreach (var element in secondArray)
      {
         Console.Write($"{element} ");
      }

      // test whether reference was changed by SecondDouble
      if (secondArray == secondArrayCopy)
      {
         Console.WriteLine("\n\nThe references refer to the same array");
      }
      else
      {
         Console.WriteLine(
            "\n\nThe references refer to different arrays");
      }
   }

   // modify elements of array and attempt to modify reference
   static void FirstDouble(int[] array)
   {
      // double each element's value                          
      for (var i = 0; i < array.Length; ++i)
      {
         array[i] *= 2;
      }

      // create new object and assign its reference to array
      array = new int[] { 11, 12, 13 };
   }

   // modify elements of array and change reference array
   // to refer to a new array                            
   static void SecondDouble(ref int[] array)
   {
      // double each element's value                     
      for (var i = 0; i < array.Length; ++i)
      {
         array[i] *= 2;
      }

      // create new object and assign its reference to array
      array = new int[] { 11, 12, 13 };
   }
}
