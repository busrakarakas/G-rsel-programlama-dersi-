using System;

class MaximumFinder
{
   
   static void Main()
   {
      // prompt for and input three floating-point values
      Console.Write("İlk sayıyı gir: ");
      double number1 = double.Parse(Console.ReadLine());
      Console.Write("ikinci sayıyı gir:");
      double number2 = double.Parse(Console.ReadLine());
      Console.Write("üçüncü sayıyı gir: ");
      double number3 = double.Parse(Console.ReadLine());

      double result = Maximum(number1, number2, number3);

      Console.WriteLine("Maximum is: " + result);
   }

   static double Maximum(double x, double y, double z)
   {
      double maximumValue = x; 

      if (y > maximumValue)
      {
         maximumValue = y;
      }

      if (z > maximumValue)
      {
         maximumValue = z;
      }

      return maximumValue;
   }
}
