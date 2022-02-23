using System;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    public struct Square
    {
        public int Length { get; set; }
        public Square(int length) : this()
        {
            Length = length;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return string.Format($"Length = {Length}");
        }

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.Length = r.Height;
            return s;
        }

        public static explicit operator Square(int i)
        {
            Square s = new Square();
            s.Length = i;
            return s;
        }
        public static explicit operator int(Square square) => square.Length;
            

    }



}
