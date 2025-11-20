using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = new string[10];

        // Input
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            names[i] = Console.ReadLine().ToUpper();
        }

        // Descending order, connected with commas
        var descending = names.OrderByDescending(n => n);
        string connectedDescending = string.Join(", ", descending);

        Console.WriteLine("\nNames in descending order:");
        Console.WriteLine(connectedDescending);

        // Ascending order
        var ascending = names.OrderBy(n => n);

        Console.WriteLine("\nNames in ascending order:");
        foreach (var n in ascending)
            Console.WriteLine(n);

        // Reverse each name (using Reverse())
        Console.WriteLine("\nReversed names (each individually reversed):");
        foreach (var n in names)
            Console.WriteLine(new string(n.Reverse().ToArray()));
    }
}
