using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class CarEventArgs:EventArgs
    {
        public readonly string message;
        public CarEventArgs(string message)
        {
            this.message = message;
        }
    }
}
