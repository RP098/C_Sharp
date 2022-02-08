using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class ComponentTypeNumber
    {
        public void TypeNumber()
        {
            Console.WriteLine("Max of int {0} min of int {1}",int.MaxValue,int.MinValue);
            Console.WriteLine("Max of double {0} min of double {1}",double.MaxValue,double.MinValue);
            Console.WriteLine("Double epsilon {0}", double.Epsilon);
            Console.WriteLine("Double negative infinity {0}", double.NegativeInfinity);
            Console.WriteLine("Double positive infinity {0}", double.PositiveInfinity);




        }

    }
}
