using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var list = new List<Box<double>>();
        var numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            var number = double.Parse(Console.ReadLine());
            var box = new Box<double>(number);
            list.Add(box);
        }
        var compareElement = double.Parse(Console.ReadLine());

        var count = GenericCountDouble(list, compareElement);
        Console.WriteLine(count);
    }

    private static object GenericCountDouble(List<Box<double>> list, double compareElement)
    {
        var counter = 0;

        foreach (var box in list)
        {
            counter += box.Value.CompareTo(compareElement) > 0 ? 1 : 0;
        }

        return counter;
    }
}