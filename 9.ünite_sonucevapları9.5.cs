using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> pets = new List<string>();

        Console.WriteLine("Enter pet names (enter blank line to stop):");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            pets.Add(input);
        }

        // a) Sort ascending by length
        var asc = pets.OrderBy(p => p.Length);

        Console.WriteLine("\nSorted ASC by name length:");
        foreach (var name in asc)
            Console.WriteLine($"{name} (length: {name.Length})");

        // b) Sort descending by length
        var desc = pets.OrderByDescending(p => p.Length);

        Console.WriteLine("\nSorted DESC by name length:");
        foreach (var name in desc)
            Console.WriteLine($"{name} (length: {name.Length})");

        // c) Remove duplicates and show count
        int uniqueCount = pets.Distinct().Count();

        Console.WriteLine($"\nPet count after removing duplicates: {uniqueCount}");
    }
}
