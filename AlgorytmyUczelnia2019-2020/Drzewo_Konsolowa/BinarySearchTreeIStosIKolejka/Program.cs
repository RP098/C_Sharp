using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stos_kolejka;

namespace drzewo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Adam Górski";
            Program program = new Program();
            program.DrzewoBstWywolanie();
            program.StosKolejkaWywolanie();
            program.drzewoWywolanie();
            Console.WriteLine("Kopiec");
            program.kopiec();
            ConsoleKeyInfo keyInfo;
            Console.Write("Press Button Esc ...");
            keyInfo = Console.ReadKey();
            Console.WriteLine("\n");
            if (keyInfo.Key != ConsoleKey.Escape)
                Main(args);
            Environment.Exit(0);
        }
        void DrzewoBstWywolanie()
        {
            DrzewoBST push = new DrzewoBST(4);

            push.Push(2);
            push.Push(1);
            push.Push(3);
            push.Push(6);
            push.Push(5);
            push.Push(7);
            Console.WriteLine("        Moje Drzewko BST \n ");
            Console.WriteLine("            {0}\n", push.korzen.wartosc);
            Console.WriteLine("        {0}       {1}\n", push.korzen.lewa.wartosc, push.korzen.prawa.wartosc);
            Console.WriteLine("      {0}   {1}   {2}   {3}", push.korzen.lewa.lewa.wartosc, push.korzen.lewa.prawa.wartosc, push.korzen.prawa.lewa.wartosc, push.korzen.prawa.prawa.wartosc);
            Console.WriteLine("Drzewo BST  wypisane metodą PreOrder");
            List<string> elementy = new List<string>();
            var ElementyDrzewaPreOrder = push.PreOrder(push.korzen, elementy);
            wypisanieDrzewa(ElementyDrzewaPreOrder);
            Console.WriteLine("Drzewo BST posortowane  metodą InOrder");
            List<string> elementyInOrder = new List<string>();
            var ElementyDrzewaInOrder = push.InOrder(push.korzen, elementyInOrder);
            wypisanieDrzewa(ElementyDrzewaInOrder);
            List<string> elementyPreOrder = new List<string>();
            Console.WriteLine("Drzewo BST wypisane metodą PostOrder");

            var ElementyDrzewaPostOrder = push.PostOrder(push.korzen, elementyPreOrder);
            wypisanieDrzewa(ElementyDrzewaPostOrder);
            Console.WriteLine();
        }

        void StosKolejkaWywolanie()
        {
            stos stos1 = new stos();
            stos1.Push(5);
            stos1.Push(4);
            stos1.Push(3);
            stos1.Push(2);

            Console.WriteLine(stos1[stos1.Lenght - 1]);
            stos1.Pop();
            Console.WriteLine(stos1[stos1.Lenght - 1]);
            stos1.Pop();
            Console.WriteLine(stos1[stos1.Lenght - 1]);
            stos1.Pop();
            Console.WriteLine(stos1[stos1.Lenght - 1]);
            stos1.Pop();
            stos1.Pop();

            kolejka kolejka1 = new kolejka();

            kolejka1.Push(5);
            kolejka1.Push(4);
            kolejka1.Push(3);
            kolejka1.Push(2);

            Console.WriteLine(kolejka1[0]);
            kolejka1.Pop();
            Console.WriteLine(kolejka1[0]);
            kolejka1.Pop();
            Console.WriteLine(kolejka1[0]);
            kolejka1.Pop();
            Console.WriteLine(kolejka1[0]);
            kolejka1.Pop();
            kolejka1.Pop();
            

        }
        void drzewoWywolanie()
        {
            drzewo Drzewo = new drzewo(0);
            for(int i=1;i<=14;i++)
                Drzewo.Push(i);
            
            Console.WriteLine("Drzewo wypisane metodą PreOrder");
            List<string> elementy = new List<string>();
            var ElementyDrzewaPreOrder=Drzewo.PreOrder(Drzewo.korzen,elementy);
            wypisanieDrzewa(ElementyDrzewaPreOrder);
            Console.WriteLine("Drzewo wypisane metodą InOrder");
            List<string> elementyInOrder = new List<string>();
            var ElementyDrzewaInOrder = Drzewo.InOrder(Drzewo.korzen, elementyInOrder);
            wypisanieDrzewa(ElementyDrzewaInOrder);
            List<string> elementyPreOrder = new List<string>();
            Console.WriteLine("Drzewo wypisane metodą PostOrder");

            var ElementyDrzewaPostOrder = Drzewo.PostOrder(Drzewo.korzen, elementyPreOrder);
            wypisanieDrzewa(ElementyDrzewaPostOrder);
        }
        void wypisanieDrzewa(List<string> elementy)
        {
            foreach (string element in elementy)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine();
            return;
        }

        void kopiec()
        {
            Kopiec kopiec = new Kopiec();
            
            kopiec.Push(1);
            kopiec.Push(2);
            kopiec.Push(3);
            kopiec.Push(4);
            kopiec.Push(5);
            kopiec.Push(51);
            kopiec.Push(53);
            kopiec.Push(512);
            kopiec.Push(53);
            kopiec.Push(1);
            kopiec.Push(2);
            kopiec.Push(7);
            kopiec.Push(3);
            kopiec.Push(4);
            kopiec.Push(5);
            kopiec.pokazKopiec();
            Console.WriteLine("Sortowanie Przez kopcowanie");
            var posortowaneElementy= kopiec.sortowaniePrzeKopcowanie();

            foreach(int i in posortowaneElementy)
            {
                Console.Write(" {0} ", i);
            }

        }
    }
}