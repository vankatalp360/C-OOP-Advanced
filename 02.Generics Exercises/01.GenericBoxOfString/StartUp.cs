using System;

class StartUp
{
    static void Main(string[] args)
    {
        var numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            var box = new Box<string>(Console.ReadLine());
            Console.WriteLine(box);
        }
    }
}