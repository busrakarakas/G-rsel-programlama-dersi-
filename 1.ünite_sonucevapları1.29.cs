using System;

class GenderNeutrality
{
    static void Main()
    {
        Console.WriteLine("Bir metin girin:");
        string text = Console.ReadLine();

        string neutralText = text
            .Replace(" he ", " they ")
            .Replace(" she ", " they ")
            .Replace(" him ", " them ")
            .Replace(" her ", " them ")
            .Replace(" his ", " their ")
            .Replace(" hers ", " theirs ");

        Console.WriteLine("\nCinsiyet Tarafsız Metin:\n" + neutralText);
    }
}
