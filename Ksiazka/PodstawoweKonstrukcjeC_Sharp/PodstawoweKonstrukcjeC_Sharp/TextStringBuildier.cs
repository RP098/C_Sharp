using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class TextStringBuildier
    {


        public static void TextBuildier()
        {
            Console.WriteLine("Using the StringBuildier");
            StringBuilder stringBuilder = new StringBuilder("lalllalalalalalal");
            stringBuilder.Append("\n");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.AppendLine("www.lalalal.plplplpl");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Clear();
            Console.WriteLine("This place should be buildier: "+ stringBuilder.ToString());
            stringBuilder.Append("New buildier");
            Console.WriteLine(stringBuilder.ToString());

        }



    }
}
