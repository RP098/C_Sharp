using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja
{
    class constructorChainning
    {
        public int number;
        public string text;
            public constructorChainning() {
            Console.WriteLine("Empty constructor");
        }
            public constructorChainning(int number):this(number,""){
            Console.WriteLine("One int constructor");
        }
            public constructorChainning(string text) : this(0, text) {
            Console.WriteLine("One string constructor");
                }
            public constructorChainning(int number, string text)
        {
            this.number = number <= 10 ? this.number:10;
            this.text = text;

            Console.WriteLine("Main constructor");
        }


    }

}
    

