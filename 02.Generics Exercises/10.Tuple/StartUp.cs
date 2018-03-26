using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToArray();
        var name = $"{input[0]} {input[1]}";
        var address = input[2];
        var firstTuple = new Tuple<string, string>(name, address);

        input = Console.ReadLine().Split().ToArray();
        name = input[0];
        var litersBeer = int.Parse(input[1]);
        var secondTuple = new Tuple<string, int>(name, litersBeer);

        input = Console.ReadLine().Split().ToArray();
        var intNumber = int.Parse(input[0]);
        var doubleNumber = double.Parse(input[1]);
        var thirdTuple = new Tuple<int, double>(intNumber, doubleNumber);

        Console.WriteLine(firstTuple);
        Console.WriteLine(secondTuple);
        Console.WriteLine(thirdTuple);
    }
}