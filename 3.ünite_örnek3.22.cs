// Fig. 3.22: Comparison.cs
// Comparing integers using if statements, equality operators,
// and relational operators.
using System;

class Comparison
{
   // Main method begins execution of C# app
   static void Main()
   {
      // prompt user and read first number
      Console.Write("Enter first integer: ");
      int number1 = int.Parse(Console.ReadLine());

      // prompt user and read second number 
      Console.Write("Enter second integer: ");
      int number2 = int.Parse(Console.ReadLine());

      if (number1 == number2)
      {
         Console.WriteLine($"{number1} == {number2}");
      }

      if (number1 != number2)
      {
         Console.WriteLine($"{number1} != {number2}");
      }

      if (number1 < number2)
      {
         Console.WriteLine($"{number1} < {number2}");
      }

      if (number1 > number2)
      {
         Console.WriteLine($"{number1} > {number2}");
      }

      if (number1 <= number2)
      {
         Console.WriteLine($"{number1} <= {number2}");
      }

      if (number1 >= number2)
      {
         Console.WriteLine($"{number1} >= {number2}");
      }
   } // end Main
} // end class Comparison


