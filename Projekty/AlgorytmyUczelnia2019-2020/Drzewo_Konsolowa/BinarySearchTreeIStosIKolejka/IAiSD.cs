using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos_kolejka
{
    interface IAiSD
    {
        int Pop();
        void Push(int a);
        int Lenght { get; }
    }
}
