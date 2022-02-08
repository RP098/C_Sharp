using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class Parsing
    {

        public static void Parse()
        {
            bool bole = bool.Parse("True");
            if (bole)
                Console.WriteLine("Sparsowane True działa {0}", int.Parse("8") + int.Parse("9"));

        }

    }
}
