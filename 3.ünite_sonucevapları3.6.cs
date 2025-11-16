 using System;
 class Product
 {
    static void Main()
    {
      int x; // stores first number to be entered by user
      int y; // stores second number to be entered by user
       int z; // stores third number to be entered by user
       int result; // product of numbers
 
       Console.Write("Enter first integer: "); // prompt for input
       x = int.Parse(Console.ReadLine()); // read first integer
 
       Console.Write("Enter second integer: "); // prompt for input
       y = int.Parse(Console.ReadLine()); // read second integer
 
       Console.Write("Enter third integer: "); // prompt for input
       z = int.Parse(Console.ReadLine()); // read third integer
 
       result = x * y * z; // calculate the product of the numbers
       Console.WriteLine($"Product is {result}");
    } // end Main
  } // end class Product
