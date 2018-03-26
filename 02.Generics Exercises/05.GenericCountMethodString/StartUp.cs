using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var list = new List<Box<string>>();
        var numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            var box = new Box<string>(Console.ReadLine());
            list.Add(box);
        }
        var compareElement = Console.ReadLine();

        var count = GenericCountStrings(list, compareElement);
        Console.WriteLine(count);
    }

    private static object GenericCountStrings(List<Box<string>> list, string compareElement)
    {
        var counter = 0;

        foreach (var box in list)
        {
            counter += box.Value.CompareTo(compareElement) > 0 ? 1 : 0;
        }

        return counter;
    }
}