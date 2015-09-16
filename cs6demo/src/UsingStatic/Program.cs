using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static UsingStatic.MyEnum;
using static System.Math;

namespace UsingStatic
{
    public class Program
    {
        public void Main(string[] args)
        {
            var frukt = Banan;

            // C# 5 and older
            switch (frukt)
            {
                case MyEnum.Banan:
                case MyEnum.Kiwi:
                case MyEnum.Apelsin:
                default:
                    break;
            }

            // With using static UsingStatic.MyEnum;
            /*
            switch (frukt)
            {
                case Banan:
                case Kiwi:
                case Apelsin:
                default:
                    break;
            }
            */

            // using static System.Math;
            var squareOf42 = Math.Pow(42, 2);
            // var squareOf42 = Pow(42, 2);
        }
    }

    enum MyEnum
    {
        Banan,
        Kiwi,
        Apelsin
    }
}
