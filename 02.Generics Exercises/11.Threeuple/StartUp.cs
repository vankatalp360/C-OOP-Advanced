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
        var town = input[3];
        var firstThreeuple = new Threeuple<string, string, string>(name, address, town);

        input = Console.ReadLine().Split().ToArray();
        name = input[0];
        var litersBeer = int.Parse(input[1]);
        var drunkLevel = input[2] == "drunk" ? "True" : "False";
        var secondThreeuple = new Threeuple<string, int, string>(name, litersBeer, drunkLevel);

        input = Console.ReadLine().Split().ToArray();
        name = input[0];
        var doubleNumber = double.Parse(input[1]);
        var bankName = input[2];
        var thirdThreeuple = new Threeuple<string, double, string>(name, doubleNumber, bankName);

        Console.WriteLine(firstThreeuple);
        Console.WriteLine(secondThreeuple);
        Console.WriteLine(thirdThreeuple);
    }
}