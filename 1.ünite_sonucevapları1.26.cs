using System;

class CarbonFootprintCalculator
{
    static void Main()
    {
        Console.Write("Günlük elektrik tüketiminizi girin (kWh): ");
        double electricity = Convert.ToDouble(Console.ReadLine());

        double carbonFootprint = electricity * 0.233; // 0.233 kg CO₂ / kWh
        Console.WriteLine($"\nTahmini günlük karbon ayak iziniz: {carbonFootprint:F2} kg CO₂");
    }
}
