using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SiecNeuronowa
{
    class WczytajProbkeAlboWagi
    {
        public List<string> wartosciZadane = new List<string>();
        public string[][] tablica;
        public string[] pobierzWagi(int  dlugosc ,string nazwa)
        {
            
            string[] tablica = new string[dlugosc];
            StreamReader streamReader = new StreamReader(nazwa);
            FileInfo fi = new FileInfo(nazwa);
         
            string line;
           

            int i = 0;
            while ((line = streamReader.ReadLine()) != null & i <= dlugosc)
            {
                tablica[i++] = line;

            }
            streamReader.Close();

            return tablica;
        }

        public WczytajProbkeAlboWagi pobierzProbki(int dlugosc,string nazwa)
        {
            WczytajProbkeAlboWagi wczytaj = new WczytajProbkeAlboWagi();
            List<string> tablica = new List<string>();
            StreamReader streamReader = new StreamReader(nazwa);
            FileInfo fi = new FileInfo(nazwa);

            string line;


            
            while ((line = streamReader.ReadLine()) != null )
            {
                tablica.Add(line);

            }

            

            streamReader.Close();
            wczytaj.tablica = new string[Convert.ToInt32(tablica.Count/(dlugosc+1))][];
            int z=0;
            for (int i=0;i<wczytaj.tablica.Length;i++)
            {
                wczytaj.tablica[i] = new string[dlugosc];
                for (int j =0;j<dlugosc;j++)
                {
                    wczytaj.tablica[i][j] =tablica[z++] ;

                }
                wczytaj.wartosciZadane.Add(tablica[z++]);
            }


            return wczytaj;
        }
    }
}
