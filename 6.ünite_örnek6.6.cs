using System;

class Interest
{
   static void Main()
   {
      decimal principal = 1000; // initial amount before interest
      double rate = 0.05; // interest rate

      // display headers
      Console.WriteLine("Year   Amount on deposit");

      // calculate amount on deposit for each of ten years  
      for (int year = 1; year <= 10; ++year)
      {
         // calculate new amount for specified year 
         decimal amount = principal *
            ((decimal)Math.Pow(1.0 + rate, year));

         // display the year and the amount         
         Console.WriteLine($"{year,4}{amount,20:C}");
      }
   }
}
