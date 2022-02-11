using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja
{
    partial class PartialClass
    {
        private int one;
        public int NumberOne { get; set; }

    }
    partial class PartialClass
    {
        public PartialClass()
        {

        }
        public PartialClass(int one)
        {
            NumberOne = one;
        }
    }
}
