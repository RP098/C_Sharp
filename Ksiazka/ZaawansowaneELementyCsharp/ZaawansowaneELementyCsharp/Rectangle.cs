using System;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle (int width,int height) : this()
        {
            Width = width;
            Height = height;
        }
        public void Draw()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return string.Format($"Width = {Width}; Height = {Height}");
        }
    }
}
