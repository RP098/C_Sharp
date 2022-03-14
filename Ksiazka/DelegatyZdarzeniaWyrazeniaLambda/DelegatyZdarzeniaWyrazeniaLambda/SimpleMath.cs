using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    public delegate  int BinaryOperation<T>(T x, T y);
    class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public  int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
