using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        ReadCommands();
    }

    private static void ReadCommands()
    {
        string input;
        var customList = new CustomList<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            var inputArgs = input.Split();
            var command = inputArgs[0];

            ExecuteCommand(command, inputArgs.Skip(1).ToList(), customList);
        }
    }

    private static void ExecuteCommand(string command, List<string> args, CustomList<string> customList)
    {
        switch (command)
        {
            case "Add":
                customList.Add(args[0]);
                break;
            case "Remove":
                /*var item = */customList.Remove(int.Parse(args[0]));
                //Console.WriteLine(item);
                break;
            case "Contains":
                var hasElement = customList.Contains(args[0]) == true ? "True" : "False";
                Console.WriteLine(hasElement);
                break;
            case "Swap": 
                customList.Swap(int.Parse(args[0]), int.Parse(args[1]));
                break;
            case "Greater":
                var count = customList.CountGreaterThan(args[0]);
                Console.WriteLine(count);
                break;
            case "Max":
                var maxElement = customList.Max();
                Console.WriteLine(maxElement);
                break;
            case "Min":
                var mineElement = customList.Min();
                Console.WriteLine(mineElement);
                break;
            case "Print":
                foreach (var element in customList)
                {
                    Console.WriteLine(element);
                }
                break;
            case "Sort":
                customList.Sort();
                break;
        }
    }
}