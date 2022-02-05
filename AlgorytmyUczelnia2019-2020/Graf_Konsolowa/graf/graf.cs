using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{

    class graf
    {
        public List<Node> Nodes;
        public List<Krawedz> Krawedzie;
        public List<Node> odwiedzone = new List<Node>();
        public List<Node> odwiedzonaKolejeczka = new List<Node>();
        public Queue<Node> kolejkaSomsiadowWierzcholka = new Queue<Node>();
        int deep = 0;

        public List<int> deep_grafu = new List<int>();

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
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public void DFS(Node n)
        {

            odwiedzone.Add(n);
            if (odwiedzone.Count == Nodes.Count)
                return;
            var krawedzie = ZnajdzKrawedzie(n);
            foreach (Krawedz k in krawedzie)
            {
                if (!odwiedzone.Contains(k.koniec))
                {
                    deep += 1;

                    DFS(k.koniec);
                }
                deep_grafu.Add(deep);


            }
            deep -= 1;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public void BFS(Node n)
        {

            kolejkaSomsiadowWierzcholka.Enqueue(n);
            while (odwiedzonaKolejeczka.Count != Nodes.Count)
            {
                var krawedzie = ZnajdzKrawedzie(kolejkaSomsiadowWierzcholka.Peek());


                foreach (Krawedz k in krawedzie)
                {

                    if (!odwiedzonaKolejeczka.Contains(k.koniec) && /*kolejkaSomsiadowWierzcholka.Peek() != k.koniec*/!kolejkaSomsiadowWierzcholka.Contains(k.koniec))
                    {

                        kolejkaSomsiadowWierzcholka.Enqueue(k.koniec);
                    }
                }


                odwiedzonaKolejeczka.Add(kolejkaSomsiadowWierzcholka.Dequeue());

            }
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public void dijsktry(Node n)
        {
            int[] tab = new int[Nodes.Count + 1];
            for (int index = 0; index < tab.Length; index++)
                tab[index] = int.MaxValue;
            tab[n.wartosc] = 0;

            kolejkaSomsiadowWierzcholka.Enqueue(n);
            while (odwiedzonaKolejeczka.Count != Nodes.Count)
            {
                var krawedzie = ZnajdzKrawedzie(kolejkaSomsiadowWierzcholka.Peek());
                foreach (Krawedz k in krawedzie)
                {
                    var nodechild = k.WezDrugi(kolejkaSomsiadowWierzcholka.Peek());
                    if (!odwiedzonaKolejeczka.Contains(nodechild))
                    {
                        kolejkaSomsiadowWierzcholka.Enqueue(nodechild);
                        //   if (tab[nodechild.wartosc] >= tab[kolejkaSomsiadowWierzcholka.Peek().wartosc] + k.waga)
                        //     tab[nodechild.wartosc] = tab[kolejkaSomsiadowWierzcholka.Peek().wartosc] + k.waga;
                        tab[nodechild.wartosc] = tab[nodechild.wartosc] >= tab[kolejkaSomsiadowWierzcholka.First().wartosc] + k.waga ? tab[kolejkaSomsiadowWierzcholka.First().wartosc] + k.waga : tab[nodechild.wartosc];
                    }
                }
                odwiedzonaKolejeczka.Add(kolejkaSomsiadowWierzcholka.Dequeue());
            }

            wypisanieDijsktry(tab, n);
            return;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        void wypisanieDijsktry(int[] tab, Node n)
        {
            int j = 1;
            foreach (int indeks in tab)
            {
                if (indeks == int.MaxValue)
                    continue;
                if (j % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Najkrótsza droga z wierzcholka  " + n.wartosc + "  do wierzcholka " + j + "  wynosi = " + indeks);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Najkrótsza droga z wierzcholka  " + n.wartosc + "  do wierzcholka " + j + "  wynosi = " + indeks);
                }
                j++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public void algorytmKruskala(graf graf1)
        {
            List<Krawedz> Krawedziesort = graf1.Krawedzie.OrderBy(k => k.waga).ToList();
            graf grafKruskal = new graf();
            grafKruskal.Krawedzie = new List<Krawedz>();
            grafKruskal.Nodes = new List<Node>();
            grafKruskal.grafdodaj(grafKruskal, Krawedziesort[0]);
            graf pomocniczy = new graf();
            pomocniczy.Krawedzie = new List<Krawedz>();
            pomocniczy.Nodes = new List<Node>();
            int index = 1;
            while (grafKruskal.Krawedzie.Count() != graf1.Nodes.Count() - 1)
            {
                int wybor = sprawdzKrawedz(grafKruskal, Krawedziesort[index]);
                switch (wybor)
                {
                    case 0:
                        pomocniczy.grafdodaj(pomocniczy, Krawedziesort[index]);
                        break;
                    case 1:
                        grafKruskal.grafdodaj(grafKruskal, Krawedziesort[index]);
                        break;
                    case 2:
                        break;

                }
                if (pomocniczy.Krawedzie.Any())
                    sprawdz_krawedzie_grafu_pomocniczego(grafKruskal, pomocniczy);
                index++;
            }
            foreach (var g in grafKruskal.Krawedzie)
                Console.WriteLine(g);
        }


        void sprawdz_krawedzie_grafu_pomocniczego(graf grafKruskal, graf pomocniczy)
        {
            for (int i = 0; i < pomocniczy.Krawedzie.Count(); i++)
            {
                int wybor2 = sprawdzKrawedz(grafKruskal, pomocniczy.Krawedzie[i]);
                switch (wybor2)
                {

                    case 1:
                        grafKruskal.grafdodaj(grafKruskal, pomocniczy.Krawedzie[i]);
                        break;
                    default:
                        break;

                }
            }
        }

        int sprawdzKrawedz(graf g, Krawedz k)
        {
            var nowa = this.Nodes.ToList();
            int wynik = 0;
            if (g.Nodes.Contains(k.start))
                wynik++;
            if (g.Nodes.Contains(k.koniec))
                wynik++;
            return wynik;
        }



        public void grafdodaj(graf g, Krawedz k)
        {

            g.Krawedzie.Add(k);
            g.Nodes.Add(k.koniec);
            g.Nodes.Add(k.start);


        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        public void AlgorytmPrima(Node start, graf graf)
        {
            graf grafPrima = new graf();
            grafPrima.Krawedzie = new List<Krawedz>();
            grafPrima.Nodes = new List<Node>();
            var krawedzie = ZnajdzKrawedzie(start).OrderBy(k => k.waga).ToList();
          
            do
            {
                

                foreach (var item in krawedzie)
                {
                    if (!(grafPrima.Nodes.Contains(item.start) && grafPrima.Nodes.Contains(item.koniec)))
                    {
                        grafPrima.grafdodaj(grafPrima, item);
                        
                        start = item.WezDrugi(start);
                        break;
                    }
                    else
                    {
                        krawedzie = krawedzie.Where(k => k != item).ToList();
                    }
                }
                
                foreach(var item in ZnajdzKrawedzie(start).OrderBy(k => k.waga).ToList())
                    krawedzie.Add(item);
                krawedzie = krawedzie.OrderBy(k => k.waga).ToList();
            } while (grafPrima.Krawedzie.Count != graf.Nodes.Count - 1);

            foreach (var item in grafPrima.Krawedzie)
            {
                Console.WriteLine(item);
            }
        }
    }
}



