using System;
using System.Linq;

class Invoice
{
    public int PartNumber { get; set; }
    public string PartDescription { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample data (Fig 9.8)
        Invoice[] invoices =
        {
            new Invoice { PartNumber = 83, PartDescription = "Electric sander", Quantity = 7,  Price = 57.98m },
            new Invoice { PartNumber = 24, PartDescription = "Power saw",       Quantity = 18, Price = 99.99m },
            new Invoice { PartNumber = 7,  PartDescription = "Sledge hammer",   Quantity = 11, Price = 21.50m },
            new Invoice { PartNumber = 77, PartDescription = "Hammer",          Quantity = 76, Price = 11.99m },
            new Invoice { PartNumber = 39, PartDescription = "Lawn mower",      Quantity = 3,  Price = 79.50m },
            new Invoice { PartNumber = 68, PartDescription = "Screwdriver",     Quantity = 106,Price = 6.99m },
            new Invoice { PartNumber = 56, PartDescription = "Jig saw",         Quantity = 21, Price = 11.00m },
            new Invoice { PartNumber = 3,  PartDescription = "Wrench",          Quantity = 34, Price = 7.50m }
        };

        // a) Sort by PartDescription
        var sortedByDescription =
            from item in invoices
            orderby item.PartDescription
            select item;

        Console.WriteLine("a) Sorted by PartDescription:");
        foreach (var i in sortedByDescription)
            Console.WriteLine($"{i.PartDescription} - {i.PartNumber} - {i.Price}");
        Console.WriteLine();


        // b) Sort by Price
        var sortedByPrice =
            from item in invoices
            orderby item.Price
            select item;

        Console.WriteLine("b) Sorted by Price:");
        foreach (var i in sortedByPrice)
            Console.WriteLine($"{i.PartDescription} - {i.Price:C}");
        Console.WriteLine();


        // c) Select PartDescription and Quantity, sorted by Quantity
        var descriptionAndQuantity =
            from item in invoices
            orderby item.Quantity
            select new { item.PartDescription, item.Quantity };

        Console.WriteLine("c) Description & Quantity sorted by Quantity:");
        foreach (var i in descriptionAndQuantity)
            Console.WriteLine($"{i.PartDescription} - Qty: {i.Quantity}");
        Console.WriteLine();


        // d) Select PartDescription and InvoiceTotal (Quantity * Price)
        var invoiceTotals =
            from item in invoices
            let total = item.Quantity * item.Price
            orderby total
            select new
            {
                item.PartDescription,
                InvoiceTotal = total
            };

        Console.WriteLine("d) Invoice totals:");
        foreach (var i in invoiceTotals)
            Console.WriteLine($"{i.PartDescription} - Total: {i.InvoiceTotal:C}");
        Console.WriteLine();


        // e) Select totals between $200 and $500
        var totalsInRange =
            from item in invoiceTotals
            where item.InvoiceTotal >= 200m && item.InvoiceTotal <= 500m
            select item;

        Console.WriteLine("e) InvoiceTotals between $200 and $500:");
        foreach (var i in totalsInRange)
            Console.WriteLine($"{i.PartDescription} - Total: {i.InvoiceTotal:C}");
    }
}
