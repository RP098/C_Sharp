using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyInżynieriWiedzy
{
    class Generuj
    {

        public double[][][] strukturaNeuronow;
        public int[] infoOstrukturze;

        public Generuj(int[] infoOstrukturze)
        {
            this.infoOstrukturze = infoOstrukturze;

            this.strukturaNeuronow = wygeneruj(infoOstrukturze);


        }

        double[][][] wygeneruj(int[] infoOstrukturze)//wzór 3-2-2 = (3+1)*2=( 3*2)+2 | pierwszy mój autorski  | drugi z zajeć
        {
            int wymiar1 = infoOstrukturze.Length - 1;

            Random random = new Random(Convert.ToInt32((DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute
                            + DateTime.Now.Second + DateTime.Now.Millisecond) / DateTime.Now.Millisecond + 2));

            double[][][] strukturaNeuronow = new double[wymiar1][][];
            for (int i = 0; i < infoOstrukturze.Length - 1; i++)
            {
                int wymiar2 = (infoOstrukturze[i] + 1);
                int wymiar3 = infoOstrukturze[i + 1];
                strukturaNeuronow[i] = new double[wymiar2][];
                for (int j = 0; j < wymiar2; j++)
                {
                    strukturaNeuronow[i][j] = new double[wymiar3];

                    for (int k = 0; k < wymiar3; k++)
                    {

                        strukturaNeuronow[i][j][k] = random.NextDouble()*random.Next(-10,10);

                    }


                }

            }



            return strukturaNeuronow;
        }
    }
}
