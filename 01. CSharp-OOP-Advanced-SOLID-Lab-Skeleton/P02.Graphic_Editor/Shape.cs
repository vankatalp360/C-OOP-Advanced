using System.Text;

namespace P02.Graphic_Editor
{
    public abstract class Shape : IShape
    {
        public abstract string Type { get; }
        

        public override string ToString()
        {
            return $"I'm {Type}";
        }
    }
}