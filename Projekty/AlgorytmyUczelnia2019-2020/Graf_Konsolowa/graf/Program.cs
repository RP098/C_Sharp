using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adam Górski Algorytmy AISD ";
            Program program = new Program();
            graf graf1 = new graf();
            Node a = new Node(1);
            Node b = new Node(2);
            Node c= new Node(3);
            Node d= new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Krawedz krawedz1 = new Krawedz(a,b);
            Krawedz krawedz2 = new Krawedz(a, c);
            Krawedz krawedz3 = new Krawedz(b, d);
            Krawedz krawedz4 = new Krawedz(c, d);
            Krawedz krawedz5 = new Krawedz(d, e);
            Krawedz krawedz6 = new Krawedz(d, f);
            graf1.Nodes = new List<Node>() {a,b,c,d,e,f };
            graf1.Krawedzie = new List<Krawedz>();
            graf1.Krawedzie.Add(krawedz1);
            graf1.Krawedzie.Add(krawedz2);
            graf1.Krawedzie.Add(krawedz3);
            graf1.Krawedzie.Add(krawedz4);
            graf1.Krawedzie.Add(krawedz5);
            graf1.Krawedzie.Add(krawedz6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            graf1.DFS(a);
            //Console.WriteLine(" \n\nPrzeszukiwanie w głąb depth " + graf1.deep_grafu.Max());
            Console.WriteLine("Przeszukiwanie w głąb");
            foreach(Node n in graf1.odwiedzone)
            {
                Console.Write(n+" ");
            }
            graf1.BFS(a);
            Console.WriteLine(" \n\nPrzeszukiwanie wszerz");
            foreach (Node n in graf1.odwiedzonaKolejeczka)
            {
                Console.Write(n + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGłębokość grafu  = ".ToUpper() + graf1.deep_grafu.Max());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.ForegroundColor = ConsoleColor.Gray;
            program.graf2();
            program.graf3();
            program.GrafAlgorytmDijsktry();
            program.kruskal();
            program.PrimaSort();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nNaciśnij Esc... Aby wyjść");
            ConsoleKeyInfo keyInfo;
            keyInfo=Console.ReadKey();
            if (keyInfo.Key != ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();            
                Main(args);
            }
            Environment.Exit(0);

        }

        void graf2()
        {
            graf graf1 = new graf();
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);
            Node h = new Node(8);
            Node i = new Node(9);
            Node j = new Node(10);
            Node k = new Node(11);
            Node l = new Node(12);
            Node r = new Node(71);
            Krawedz krawedz1 = new Krawedz(a, b);
            Krawedz krawedz2 = new Krawedz(a, g);
            Krawedz krawedz3 = new Krawedz(a, h);
            Krawedz krawedz4 = new Krawedz(b, c);
            Krawedz krawedz5 = new Krawedz(b, f);
            Krawedz krawedz6 = new Krawedz(c, d);
            Krawedz krawedz7 = new Krawedz(c, e);
            Krawedz krawedz71 = new Krawedz(e, r);
            Krawedz krawedz8 = new Krawedz(h, i);
            Krawedz krawedz9 = new Krawedz(h, l);
            Krawedz krawedz10 = new Krawedz(i, j);
            Krawedz krawedz11 = new Krawedz(i, k);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            Console.WriteLine(krawedz7);
            Console.WriteLine(krawedz71);
            Console.WriteLine(krawedz8);
            Console.WriteLine(krawedz9);
            Console.WriteLine(krawedz10);
            Console.WriteLine(krawedz11);
            
            graf1.Nodes = new List<Node>() { a, b, c, d, e, f,g ,h,i,j,k,l,r};
            graf1.Krawedzie = new List<Krawedz>() {krawedz1,krawedz2,krawedz3,krawedz4,krawedz5,krawedz6,krawedz7,krawedz71,krawedz8,krawedz9,krawedz10,krawedz11 };
            graf1.DFS(a);
            Console.WriteLine(" \nPrzeszukiwanie w głąb");
            foreach (Node n in graf1.odwiedzone)
            {
                Console.Write(n+" ");
            }
            //Console.WriteLine(" \n\nPrzeszukiwanie w głąb depth  "+graf1.deep_grafu.Max());
            graf1.BFS(a);
            Console.WriteLine(" \n\nPrzeszukiwanie wszerz");
            foreach (Node n in graf1.odwiedzonaKolejeczka)
            {
                Console.Write(n + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGłębokość grafu  = ".ToUpper() + graf1.deep_grafu.Max());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void graf3()
        {
            graf graf1 = new graf();
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);
      
            Krawedz krawedz1 = new Krawedz(a, b);
            Krawedz krawedz2 = new Krawedz(a, c);
            Krawedz krawedz3 = new Krawedz(a, e);
            Krawedz krawedz4 = new Krawedz(b, d);
            Krawedz krawedz5 = new Krawedz(b, f);
            Krawedz krawedz6 = new Krawedz(c, g);
            Krawedz krawedz7 = new Krawedz(f, e);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
        
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            Console.WriteLine(krawedz7);
            

            graf1.Nodes = new List<Node>() { a, b, c, d, e, f,g };
            graf1.Krawedzie = new List<Krawedz>() { krawedz1, krawedz2,  krawedz3, krawedz4, krawedz5, krawedz6, krawedz7, };
            graf1.DFS(a);
            
            Console.WriteLine(" \nPrzeszukiwanie w głąb");
            foreach (Node n in graf1.odwiedzone)
            {
                Console.Write(n + " ");
            }

            graf1.BFS(a);
            Console.WriteLine(" \n\nPrzeszukiwanie wszerz");
            foreach (Node n in graf1.odwiedzonaKolejeczka)
            {
                Console.Write(n + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGłębokość grafu = ".ToUpper()+graf1.deep_grafu.Max());
            Console.ForegroundColor = ConsoleColor.Gray;

            
        }
        void GrafAlgorytmDijsktry()
        {
            graf graf1 = new graf();
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Krawedz krawedz1 = new Krawedz(a, b,7);
            Krawedz krawedz2 = new Krawedz(a, c,9);
            Krawedz krawedz3 = new Krawedz(a, f,14);
        
            Krawedz krawedz4 = new Krawedz(b, c,10);
            Krawedz krawedz5 = new Krawedz(b, d,15);
  
            Krawedz krawedz6 = new Krawedz(c, f,2);
            Krawedz krawedz7 = new Krawedz(c, d,11);
            

            Krawedz krawedz8 = new Krawedz(d, e,6);
           
            Krawedz krawedz9 = new Krawedz(f, e,9);
           
            graf1.Nodes = new List<Node>() { a, b, c, d, e, f};
            graf1.Krawedzie = new List<Krawedz>() { krawedz1, krawedz2, krawedz3, krawedz4, krawedz5, krawedz6, krawedz7,krawedz8,krawedz9 };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            Console.WriteLine(krawedz7);
            Console.WriteLine(krawedz8);
            Console.WriteLine(krawedz9);
            graf1.dijsktry(a);
           

        }
        void kruskal()
        {
            graf graf1 = new graf();
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Krawedz krawedz1 = new Krawedz(a, e, 1);
            Krawedz krawedz2 = new Krawedz(c, d, 2);
            Krawedz krawedz3 = new Krawedz(a, b, 3);

            Krawedz krawedz4 = new Krawedz(b, e, 4);
            Krawedz krawedz5 = new Krawedz(b, c, 5);

            Krawedz krawedz6 = new Krawedz(c, e, 6);
            Krawedz krawedz7 = new Krawedz(d, e, 7);
            graf1.Nodes = new List<Node>() { a, b, c, d, e};
            graf1.Krawedzie = new List<Krawedz>() { krawedz1, krawedz2, krawedz3, krawedz4, krawedz5, krawedz6, krawedz7};

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            Console.WriteLine(krawedz7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Algrytm Kruskala");
            Console.ForegroundColor = ConsoleColor.Gray;
            graf1.algorytmKruskala(graf1);

        }
        void PrimaSort()
        {
            graf graf1 = new graf();
            Node a = new Node(0);
            Node b = new Node(1);
            Node c = new Node(2);
            Node d = new Node(3);
            Node e = new Node(4);
            Node f = new Node(5);
            Node g = new Node(6);
            Node h = new Node(7);
            Krawedz krawedz1 = new Krawedz(a, b, 5);
            Krawedz krawedz2 = new Krawedz(a, g, 3);
            Krawedz krawedz3 = new Krawedz(a, d, 9);

            Krawedz krawedz4 = new Krawedz(b, e, 8);
            Krawedz krawedz5 = new Krawedz(b, c, 9);

            Krawedz krawedz6 = new Krawedz(b, h, 7);
            Krawedz krawedz7 = new Krawedz(c, d, 9);
            Krawedz krawedz8 = new Krawedz(c, e, 4);
            Krawedz krawedz9 = new Krawedz(c, g, 5);
            Krawedz krawedz10 = new Krawedz(c, h, 3);
            Krawedz krawedz11 = new Krawedz(d, g, 8);
            Krawedz krawedz12 = new Krawedz(e, f, 2);
            Krawedz krawedz13 = new Krawedz(e, g, 1);
            Krawedz krawedz14 = new Krawedz(f, g, 6);
            Krawedz krawedz15 = new Krawedz(g, h, 9);
            graf1.Nodes = new List<Node>() { a, b, c, d, e,f,g,h };
            graf1.Krawedzie = new List<Krawedz>() { krawedz1, krawedz2, krawedz3, krawedz4, krawedz5, krawedz6, krawedz7
            ,krawedz8,krawedz9,krawedz10,krawedz11,krawedz12,krawedz13,krawedz14,krawedz15};

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nStruktura grafu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(krawedz1);
            Console.WriteLine(krawedz2);
            Console.WriteLine(krawedz3);
            Console.WriteLine(krawedz4);
            Console.WriteLine(krawedz5);
            Console.WriteLine(krawedz6);
            Console.WriteLine(krawedz7);
            Console.WriteLine(krawedz8);
            Console.WriteLine(krawedz9);
            Console.WriteLine(krawedz10);
            Console.WriteLine(krawedz11);
            Console.WriteLine(krawedz12);
            Console.WriteLine(krawedz13);
            Console.WriteLine(krawedz14);
            Console.WriteLine(krawedz15);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Algrytm Prima");
            Console.ForegroundColor = ConsoleColor.Gray;
            graf1.AlgorytmPrima(a,graf1);

        }

    }

}
