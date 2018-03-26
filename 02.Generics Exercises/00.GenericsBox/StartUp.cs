using System;

class StartUp
{
    static void Main(string[] args)
    {
        var value = 123123;
        var box = new Box<int>(value);
        Console.WriteLine(box);
    }
}