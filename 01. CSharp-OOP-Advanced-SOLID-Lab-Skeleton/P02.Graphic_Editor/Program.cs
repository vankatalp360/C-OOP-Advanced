using System;
using System.Collections.Generic;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            var shapes = new List<IShape>();
            shapes.Add(new Square());
            shapes.Add(new Rectangle());
            shapes.Add(new Circle());

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
