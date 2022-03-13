using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiecNeuronowa
{

    class graf
    {
        public List<Node> Nodes;
        public List<Krawedz> Krawedzie;
        public List<Node> odwiedzone = new List<Node>();
        public List<Node> odwiedzonaKolejeczka = new List<Node>();
        public Queue<Node> kolejkaSomsiadowWierzcholka = new Queue<Node>();
        public static string struktura;
        public string[] wagiZpliku;//podawane z pliku
        public string[] wartosciWejscia;//podawane z pliku
        public List<int> deep_grafu = new List<int>();
        public static double WartoscZadana = 1;
        public static double Beta = 1;
        public static double MiWspolczynnikUczenia = 0.1;
        public static List<double> wartosciZadaneNaWyjscia = new List<double>();
        public List<Krawedz> ZnajdzKrawedzie(Node n)
        {
            List<Krawedz> wynik = new List<Krawedz>();

            for (int i = 0; i < this.Krawedzie.Count; i++)
            {
                var k = this.Krawedzie[i];
                if (k.start == n || k.koniec == n)
                {
                    wynik.Add(k);

                }
            }
            return wynik;
        }

        public void grafdodaj(graf g, Krawedz k)
        {

            g.Krawedzie.Add(k);
            g.Nodes.Add(k.koniec);
            g.Nodes.Add(k.start);


        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        public List<Node> AutomatyczneTworzenieNodow(string struktura)
        {
            List<Node> tablicaNodow = new List<Node>();
            string[] pom = struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            int dlugosc = liczbaNodow(pom);
            for (int i = 0; i < dlugosc; i++)
                tablicaNodow.Add(new Node(i));
            return tablicaNodow;


        }

        public int liczbaNodow(string[] struktura)
        {
            int dlugosc = Convert.ToInt32(struktura[0]);

            for (int i = 1; i < struktura.Length; i++)
            {
                dlugosc += (Convert.ToInt32(struktura[i]) + Convert.ToInt32(struktura[i]));
            }
            return dlugosc;
        }
        //przypisanie wartosci nodow z pliku
        public List<Node> PrzypiszWartosciDoNodow(string[] wartosciZpliku, List<Node> nodes)
        {

            for (int i = 0; i < wartosciZpliku.Length; i++)
                nodes[i].wartosc = Convert.ToDouble(wartosciZpliku[i]);


            return nodes;
        }




        //oraz automatyczne robienie połączeń w grafie
        public List<Krawedz> ZwrocKrawedzie(List<Node> nodes, string[] struktura)
        {
            int d = 0;
            List<Krawedz> krawedzs = new List<Krawedz>();
            int dlugosc = LiczbaKrawedzi(struktura);
            int c = 0;
            int antenka = Convert.ToInt32(struktura[0]);
            int nast = 0;
            int dodNast = 0;
            do
            {
                int ile = Convert.ToInt32(struktura[d + 1]);//2-{2}
                int a = -ile;
                antenka += (Convert.ToInt32(struktura[d + 1]) + Convert.ToInt32(struktura[d + 1]));
                nast += Convert.ToInt32(struktura[d]) + dodNast;
                for (int j = 0; j < ile; j++)
                {

                    for (int z = 0; z < Convert.ToInt32(struktura[d]) + 1; z++)//{2+1}
                    {

                        Krawedz krawedz = new Krawedz(nodes[z + c], nodes[j + nast]);


                        if (z == Convert.ToInt32(struktura[d])) //ostatnia to antenka
                        {

                            krawedz = new Krawedz(nodes[antenka + a], nodes[j + nast]);


                        }
                        krawedzs.Add(krawedz);

                    }
                    a++;
                }
                if (d == 0)
                    c += Convert.ToInt32(struktura[d]);
                else
                    c += (Convert.ToInt32(struktura[d]) * 2);
                d++;
                dodNast = (Convert.ToInt32(struktura[d]));

            }
            while (krawedzs.Count < dlugosc);


            return krawedzs;
        }

        public int LiczbaKrawedzi(string[] struktura)
        {
            int dlugosc = 0;

            for (int i = 0; i < struktura.Length - 1; i++)
            {

                dlugosc += ((Convert.ToInt32(struktura[i]) + 1) * Convert.ToInt32(struktura[i + 1]));

            }



            return dlugosc;
        }


        public List<Krawedz> przypisWartosciDoKrawedzi(List<Krawedz> krawedzs, string[] wartosci)
        {
            for (int i = 0; i < krawedzs.Count; i++)
                krawedzs[i].waga = Convert.ToDouble(wartosci[i]);


            return krawedzs;
        }
        public List<Krawedz> obliczWyjscia(List<Node> nodes, List<Krawedz> krawedzs, string[] struktura)//trzeba na nodach
        {
            int d = 0;
            int dlugosc = LiczbaKrawedzi(struktura);
            int c = 0;
            int antenka = Convert.ToInt32(struktura[0]);
            int nast = 0;
            int dodNast = 0;
            List<Krawedz> krawedzsNowa = new List<Krawedz>();
            int e = 0;
            do
            {
                int ile = Convert.ToInt32(struktura[d + 1]);
                int a = -ile;
                antenka += (Convert.ToInt32(struktura[d + 1]) + Convert.ToInt32(struktura[d + 1]));
                nast += Convert.ToInt32(struktura[d]) + dodNast;
                for (int j = 0; j < ile; j++)
                {

                    for (int z = 0; z < Convert.ToInt32(struktura[d]) + 1; z++)
                    {

                        Krawedz krawedz = new Krawedz(nodes[z + c], nodes[j + nast], krawedzs[e].waga);
                        if (z == 0)
                            krawedzs[e].koniec.wartosc = krawedzs[e].start.wartosc * krawedzs[e].waga;
                        else
                            krawedzs[e].koniec.wartosc += krawedzs[e].start.wartosc * krawedzs[e].waga;

                        if (z == Convert.ToInt32(struktura[d])) //ostatnia to antenka
                        {

                            krawedz = new Krawedz(nodes[antenka + a], nodes[j + nast]);
                            nodes[j + nast].wartosc = funkcjaAktywacji(krawedzs[e].koniec.wartosc);

                        }
                        krawedzsNowa.Add(krawedz);
                        e++;
                    }
                    a++;
                }

                if (d == 0)
                    c += Convert.ToInt32(struktura[d]);
                else
                    c += (Convert.ToInt32(struktura[d]) * 2);
                d++;
                dodNast = (Convert.ToInt32(struktura[d]));

            } while (krawedzsNowa.Count < dlugosc);


            return krawedzs;
        }

        double funkcjaAktywacji(double suma)
        {
            suma = 1 / (1 + Math.Exp((-1) * suma));

            return suma;
        }
        public double blad(double wartoscZadana, double wartoscWyjsciowa)
        {
            return wartoscZadana - wartoscWyjsciowa;

        }

        //delta wyjscia //korekta
        public double deltaWyjscia(double WartoscZadana, double Wyjscie)
        {
            return graf.MiWspolczynnikUczenia * (WartoscZadana - Wyjscie);
        }

        //delta sumy
        public double deltaSumy(double deltaWyjscia, double wyjscie)
        {

            return deltaWyjscia * graf.Beta * wyjscie * (1 - wyjscie);
        }

        public List<Krawedz> wstecznaPropagacjaZmianaWag(List<Krawedz> krawedzs)
        {
            graf graf1 = new graf();

            int dlugosc = LiczbaKrawedzi(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
            string[] struktura = graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            int ostatniaWarstwa = (Convert.ToInt32(struktura[struktura.Length - 2]) + 1) * Convert.ToInt32(struktura[struktura.Length - 1]);
            ostatniaWarstwa = krawedzs.Count - ostatniaWarstwa;
            ostatniaWarstwa--;
            List<double> Deltabledow = new List<double>();
            int d = struktura.Length - 2;

            List<Krawedz> krawedzsNowa = new List<Krawedz>();
            int e = dlugosc - 1;
            //var deltaWyjscia = Math.Round(graf1.deltaWyjscia(graf.WartoscZadana, krawedzs[e].koniec.wartosc),5);
            double deltaWyjscia = 0;
            //var deltaSumy = Math.Round(graf1.deltaSumy(deltaWyjscia, krawedzs[e].koniec.wartosc),5);
            double deltaSumy = 0;
            do
            {
                int ile = Convert.ToInt32(struktura[d + 1]);



                for (int j = 0; j < ile; j++)
                {



                    for (int z = 0; z < Convert.ToInt32(struktura[d]) + 1; z++)
                    {

                        Krawedz krawedz = new Krawedz(new Node(1), new Node(1), krawedzs[e].waga);

                        if (e <= ostatniaWarstwa)
                        {

                            if (z == 0)
                            {
                                deltaSumy = graf1.deltaSumy(Deltabledow[j], krawedzs[e].koniec.wartosc);
                                krawedzs[e].waga = (deltaSumy * 1) + krawedzs[e].waga;
                            }
                            else
                            {
                                deltaSumy = graf1.deltaSumy(Deltabledow[j], krawedzs[e].koniec.wartosc);
                                krawedzs[e].waga = (deltaSumy * krawedzs[e].start.wartosc) + krawedzs[e].waga;
                            }

                        }
                        else if (e > ostatniaWarstwa & z == 0)
                        {
                            deltaWyjscia = Math.Round(graf1.deltaWyjscia(graf.wartosciZadaneNaWyjscia[j], krawedzs[e].koniec.wartosc), 5);
                            deltaSumy = Math.Round(graf1.deltaSumy(deltaWyjscia, krawedzs[e].koniec.wartosc), 5);
                            krawedzs[e].waga = deltaSumy * 1 + krawedzs[e].waga;

                        }
                        else
                        {

                            deltaSumy = Math.Round(graf1.deltaSumy(deltaWyjscia, krawedzs[e].koniec.wartosc), 5);
                            if (j == 0)
                                Deltabledow.Add(deltaSumy * krawedzs[e].waga);
                            else
                                Deltabledow[z - 1] += deltaSumy * krawedzs[e].waga;
                            krawedzs[e].waga = deltaSumy * krawedzs[e].start.wartosc + krawedzs[e].waga;


                        }


                        krawedzsNowa.Add(krawedz);
                        e--;
                    }

                }


                d--;


            } while (krawedzsNowa.Count < dlugosc);


            return krawedzs;

        }


    }
}



