using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs6demo
{
    public class AutoPropertyInitializers
    {
        public string Fruit { get; set; } = "Banan";
    }

    public class GetterOnlyInitializer
    {
        public string Fruit { get; } = "Kiwi";
    }

    public class GetterOnlyProperties
    {
        public string Fruit { get; }

        public GetterOnlyProperties()
        {
            Fruit = "Apelsin";
        }
    }

    public class ExpressionBodiedFunctionMembers
    {
        public int X { get; }
        public int Y { get; }

        public ExpressionBodiedFunctionMembers Add(ExpressionBodiedFunctionMembers other) => new ExpressionBodiedFunctionMembers(X + other.X, Y + other.Y);

        public float Length => (float)Math.Sqrt(X * X + Y * Y);

        public ExpressionBodiedFunctionMembers(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine(new AutoPropertyInitializers().Fruit);
            Console.WriteLine(new GetterOnlyInitializer().Fruit);
            Console.WriteLine(new GetterOnlyProperties().Fruit);
        }
    }
}
