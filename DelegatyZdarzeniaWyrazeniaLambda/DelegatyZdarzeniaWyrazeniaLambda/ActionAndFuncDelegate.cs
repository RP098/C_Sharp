using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class ActionAndFuncDelegate
    {
       public static void DisplayMessage(string message,ConsoleColor consoleColor, int printCount)
        {
            ConsoleColor consoleColor1 = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            for (int s = 0; s < printCount; s++)
            {
                Console.WriteLine(message);
            }
            Console.ForegroundColor = consoleColor1;
        }
    }
}
