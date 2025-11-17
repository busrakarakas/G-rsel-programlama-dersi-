  using System;
 
  class Sphere
  {
    // obtain radius from user and display volume of sphere
    static void Main()
    {
      Console.Write("Enter radius of sphere: ");
      double radius = double.Parse(Console.ReadLine());
      Console.WriteLine("Volume is {SphereVolume(radius):F3}");
    } 

   // calculate and return sphere volume
    static double SphereVolume(double radius) =>
       (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
  }       
