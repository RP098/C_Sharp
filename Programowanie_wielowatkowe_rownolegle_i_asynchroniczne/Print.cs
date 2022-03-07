using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Programowanie_wielowatkowe_rownolegle_i_asynchroniczne
{
    class Print
    {
        private object threadLock = new object();
        public void print_Number()
        {
            lock (threadLock)
            {
                Console.WriteLine("Current Thread {0}", Thread.CurrentThread.Name);
                Console.WriteLine("Your number");
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(500 * random.Next(5));
                }
                Console.WriteLine();
            }
        }


    }
}
