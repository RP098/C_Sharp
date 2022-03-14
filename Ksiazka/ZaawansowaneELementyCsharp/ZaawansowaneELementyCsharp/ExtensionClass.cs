using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ZaawansowaneELementyCsharp
{
    static class ExtensionClass
    {
        public static int ReverseDigits(this int number)
        {
            char[] digits = number.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }

        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
                Console.Beep();
                Thread.Sleep(1000);
            }
        }

    }
}
