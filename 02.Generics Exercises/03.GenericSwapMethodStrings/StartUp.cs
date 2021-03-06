﻿using System;
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
        var swapArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        GenericSwapMethod(list, swapArgs);
        foreach (var box in list)
        {
            Console.WriteLine(box);
        }
    }

    public static void GenericSwapMethod<T>(List<T> list, int[] swapArgs)
    {
        var firstIndex = swapArgs[0];
        var secondIndex = swapArgs[1];

        var firstBox = list[secondIndex];
        list[secondIndex] = list[firstIndex];
        list[firstIndex] = firstBox;
    }
}