using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class ConsoleFormat
    {
        public void BasicalFormatConsole()
        {
            
        Console.WriteLine("c format: {0:c}", 9999);
        Console.WriteLine("d format: {0:d}", 9999);
        Console.WriteLine("d5 format: {0:d5}", 9999);
        Console.WriteLine("f format: {0:f}", 9999);
        Console.WriteLine("f3 format: {0:f3}", 9999);
        Console.WriteLine("n format: {0:n}",  9999);
        Console.WriteLine("E format: {0:E}", 9999);
        Console.WriteLine("e format: {0:e}", 9999);
        Console.WriteLine("X format: {0:X}", 9999);
        Console.WriteLine("x format: {0:x}", 9999);
        string ciag = String.Format("String Format {0:x}",9999);
          Console.WriteLine(ciag);
    }
    }
}
