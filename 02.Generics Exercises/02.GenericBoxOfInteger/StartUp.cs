using System;

class StartUp
{
    static void Main(string[] args)
    {
        var numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            var number = int.Parse(Console.ReadLine());
            var box = new Box<int>(number);
            Console.WriteLine(box);
        }
    }
}