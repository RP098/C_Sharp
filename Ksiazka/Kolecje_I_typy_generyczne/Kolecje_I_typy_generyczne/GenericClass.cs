using System;
using System.Collections.Generic;
using System.Text;

namespace Kolecje_I_typy_generyczne
{
    class GenericClass<T> where T: new() //must be default constructor  
    {
        public T xPos { get; set; }
        public T yPos { get; set; }
        public GenericClass()
        {
            xPos = default(T); //Declaring default values for specified type.
            yPos = default(T);
        }


    }
}

