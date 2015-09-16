using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionAndPropertyShorthands
{
    class Point
    {
        // Getter-only auto-property initializers
        public float X { get; } = 33;
        public float Y { get; } = 33;

        // Auto-property initializers
        // public float Z { get; set; } = 0;

        // Expression bodies on property-like function members
        public float Length => (float)Math.Sqrt(X * X + Y * Y);

        // Expression-bodied function members
        public Point Normalize(float newLength) => new Point(X / Length * newLength, Y / Length * newLength);
        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

        public Point()
        { }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X};{Y}";
        }
    }

    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine(new Point());

            var p = new Point(10, 10);
            Console.WriteLine($"p:          {p.Length}");

            var pointLen20 = p.Normalize(20);
            Console.WriteLine($"pointLen20: {pointLen20}");

            Console.WriteLine($"add:        {p + pointLen20}");
        }
    }
}
