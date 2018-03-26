using System;

class StartUp
{
    static void Main(string[] args)
    {
        var scale = new Scale<string>("Anko", "Anko");
        Console.WriteLine(scale.GetHeavier());
    }
}