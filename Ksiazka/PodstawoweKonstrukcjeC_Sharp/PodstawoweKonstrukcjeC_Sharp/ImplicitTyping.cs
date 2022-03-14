using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PodstawoweKonstrukcjeC_Sharp
{
    class ImplicitTyping
    {
        public void TypingLinqu()
        {
            int[] numbers = {1,10,20,30,40,50,60,70,80,80,2,8,11,4,2,6,9,2};
            var subset = from i in numbers where i < 10 select i ;

            Console.WriteLine("Values in subset");
            foreach (var i in subset) 
                Console.WriteLine("{0}",i);
            Console.WriteLine(subset.GetType());

        }

    }
}
