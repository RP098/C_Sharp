using System;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    class IndexerMultidimensionalArray
    {
        private int[,] table = new int[10,10];
        public int this[int row,int column]
        {
            get { return table[row,column]; }
            set { table[row,column] = value; }
        }

    }
}
