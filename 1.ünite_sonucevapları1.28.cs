using System;

class HybridCar
{
    public string Model { get; set; }
    public double FuelEfficiency { get; set; } // km/L
    public double BatteryCapacity { get; set; } // kWh
    public double ElectricRange { get; set; } // km

    public void DisplayInfo()
    {
        Console.WriteLine($"\nModel: {Model}");
        Console.WriteLine($"Yakıt Verimliliği: {FuelEfficiency} km/L");
        Console.WriteLine($"Batarya Kapasitesi: {BatteryCapacity} kWh");
        Console.WriteLine($"Elektrikli Menzil: {ElectricRange} km");
    }
}

class Program
{
    static void Main()
    {
        HybridCar car = new HybridCar();

        Console.Write("Araç modelini girin: ");
        car.Model = Console.ReadLine();

        Console.Write("Yakıt verimliliği (km/L): ");
        car.FuelEfficiency = Convert.ToDouble(Console.ReadLine());

        Console.Write("Batarya kapasitesi (kWh): ");
        car.BatteryCapacity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Elektrikli menzil (km): ");
        car.ElectricRange = Convert.ToDouble(Console.ReadLine());

        car.DisplayInfo();
    }
}
