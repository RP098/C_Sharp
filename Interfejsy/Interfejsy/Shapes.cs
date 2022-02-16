using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    class Shapes : ICircle, ISquare, IEnumerable,ICloneable
    {
        public string name { get; set; }
        public Shapes[] shapes = new Shapes[4];
        public Shapes()
        {
            
            shapes[0] = new Shapes("name");
            shapes[1] = new Shapes("name1");
            shapes[2] = new Shapes("name2");
            shapes[3] = new Shapes("name3");

           
        }

        public Shapes(string name)
        {
            this.name = name;
        }

        public void draw()
        {
            Console.WriteLine("I draw shape");
        }

        void ICircle.draw()
        {
            Console.WriteLine("I draw shape Circle");
        }
        void ISquare.draw()
        {
            Console.WriteLine("I draw shape Square");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
        
            return shapes.GetEnumerator();
        }

        public object Clone()
        {
            Shapes shapes = (Shapes)this.MemberwiseClone();
            Shapes shapes1 = new Shapes();
            shapes1.shapes[0].name= this.shapes[0].name;
            shapes.shapes = shapes1.shapes;
            return shapes;
           // return this.MemberwiseClone();
        }
    }
}
