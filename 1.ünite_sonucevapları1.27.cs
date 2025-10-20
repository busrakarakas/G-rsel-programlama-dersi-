using System;

class BMICalculator
{
    static void Main()
    {
        Console.Write("Kilonuzu girin (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Boyunuzu girin (metre): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"\nVücut Kitle İndeksiniz: {bmi:F2}");

        if (bmi < 18.5)
            Console.WriteLine("Durum: Zayıf");
        else if (bmi < 25)
            Console.WriteLine("Durum: Normal");
        else if (bmi < 30)
            Console.WriteLine("Durum: Fazla kilolu");
        else
            Console.WriteLine("Durum: Obez");
    }
}
