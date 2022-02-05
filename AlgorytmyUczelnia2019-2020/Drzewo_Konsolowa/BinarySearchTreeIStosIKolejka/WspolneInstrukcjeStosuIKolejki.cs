using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos_kolejka
{
    abstract class SD
    {

        protected int[] dane;
        public int Lenght
        {
            get;
            protected set;
        }



        public SD()
        {
            this.Lenght = 0;
            this.dane = new int[this.Lenght];
        }

        public int this[int index]
        {
            get { return this.dane[index]; }
            set { this.dane[index] = value; }
        }



        public void Push(int element)
        {
            this.Lenght++;
            int[] tmp = this.Przepisz(this.dane);

            tmp[this.Lenght - 1] = element;
            this.dane = tmp;


        }
        protected int[] Przepisz(int[] stara)
        {

            int[] nowa = new int[stara.Length + 1];
            for (int i = 0; i < stara.Length; i++)
            {
                nowa[i] = stara[i];
            }
            return nowa;
        }
    }
}