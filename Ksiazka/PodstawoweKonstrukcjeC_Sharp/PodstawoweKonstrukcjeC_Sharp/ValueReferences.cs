using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class ValueReferences
    {
        public int modifierOut(int x, int y, out int ans)
        {
            ans = x + y;
            return ans;
        }
        public int modifierRef(int x, int y, ref int ans)
        {
            ans = x + y+ans;
            return ans;
        }

        public int modifierParams( params int [] tableInt )
        {
            int suma = new int();
         foreach (int d in tableInt)
            {
                suma += d;
            }

            return suma;
        }
    }
}
