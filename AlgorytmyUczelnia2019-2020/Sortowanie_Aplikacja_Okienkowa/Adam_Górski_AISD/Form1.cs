using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Górski_AISD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dane_TextChanged(object sender, EventArgs e)
        {

        }

        private void bombelkowe_Click(object sender, EventArgs e)
        {
            var liczbys = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> tab = new List<int>();
            int i = 0;
            int dlugosc;
            dlugosc = liczbys.Length;
            for (i = 0; i < dlugosc; i++)
            {
                int tmp = int.Parse(liczbys[i]);
                tab.Add(tmp);

            }
            tab = Sortuj_Bombelkowo(tab);
            dane.Text = string.Join(" ", tab.ToArray());
        }
        List<int> Sortuj_Bombelkowo(List<int> liczby)
        {
            int tmp;
            bool zamiana;
            int i = 0;
            do
            {
                zamiana = false;
                for (i = 0; i < liczby.Count - 1; i++)
                {
                    if (liczby[i] > liczby[i + 1])
                    {
                        tmp = liczby[i + 1];
                        liczby[i + 1] = liczby[i];
                        liczby[i] = tmp;
                        zamiana = true;

                    }
                }


            } while (zamiana);

            return liczby;
        }
        private void przez_wybor_Click(object sender, EventArgs e)
        {
            var liczbys = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> tab = new List<int>();
            int i = 0;
            int dlugosc;
            dlugosc = liczbys.Length;
            for (i = 0; i < dlugosc; i++)
            {
                int tmp = int.Parse(liczbys[i]);
                tab.Add(tmp);

            }
            tab = Sortuj_przez_wybor(tab);
            dane.Text = string.Join(" ", tab.ToArray());
        }

        List<int> Sortuj_przez_wybor(List<int> liczby)
        {
            int tmp;
            int i = 0;
            int j;
            for (i = 0; i < liczby.Count; i++)
            {
                for (j = i; j < liczby.Count; j++)
                {
                    if (liczby[i] > liczby[j])
                    {
                        tmp = liczby[j];
                        liczby[j] = liczby[i];
                        liczby[i] = tmp;

                    }
                }
            }



            return liczby;
        }
        private void przez_wstawianie_Click(object sender, EventArgs e)
        {
            var liczbyString = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> liczby = new List<int>();
            int i = 0;
            int dlugosc;
            dlugosc = liczbyString.Length;
            for (i = 0; i < dlugosc; i++)
            {
                int tmp = int.Parse(liczbyString[i]);
                liczby.Add(tmp);
            }
            liczby = Sortuj_przez_wstawianie(liczby);
            dane.Text = string.Join(" ", liczby.ToArray());
        }

        List<int> Sortuj_przez_wstawianie(List<int> liczby)
        {
            int tmp;
            int i = 0;
            int j;
            for (i = 1; i < liczby.Count; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (liczby[i] < liczby[j])
                    {
                        tmp = liczby[i];
                        liczby[i] = liczby[j];
                        liczby[j] = tmp;

                    }
                }
            }



            return liczby;
        }
        private void przez_zliczanie_Click(object sender, EventArgs e)
        {
            var liczbyString = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> liczby = new List<int>();
            int i = 0;
            int dlugosc;
            dlugosc = liczbyString.Length;
            for (i = 0; i < dlugosc; i++)
            {
                int tmp = int.Parse(liczbyString[i]);
                liczby.Add(tmp);
            }
            liczby = Sortuj_przez_zliczanie(liczby);
            dane.Text = string.Join(" ", liczby.ToArray());
        }
        List<int> Sortuj_przez_zliczanie(List<int> tab)
        {
            int i = 0;
            int max;


            int rozmiar = tab.Count;
            max = maxing(tab);

            int[] tab1 = new int[max];
            for (i = 0; i < max; i++)
            {
                tab1[i] = 0;
            }

            for (i = 0; i < rozmiar; i++)
            {

                tab1[tab[i]] += 1;


            }
            int j = 0;


            for (i = 0; i < max; i++)
            {

                while (tab1[i] > 0)
                {

                    tab[j++] = i;
                    tab1[i]--;

                }
            }
            return tab;
        }
        int maxing(List<int> tab)
        {
            int rozmiar = tab.Count;
            int i;
            int max = 0;
            int tmp;
            i = 0;
            int j = 0;
            for (i = 0; i < rozmiar - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    max = tab[i];
                    tmp = tab[i + 1];
                    tab[i + 1] = tab[i];
                    tab[i] = tmp;

                }

            }
            max += 1;
            return max;
        }

        private void ciagFib_Click(object sender, EventArgs e)
        {

            int zakres = Convert.ToInt32(dane.Text);
            zakres = ciagfib(zakres);
            dane.Text = Convert.ToString(zakres) + " obliczony rekurencyjnie";
        }

        public int ciagfib(int zakres)
        {
            switch (zakres)
            {
                case 1:
                    return 1;
                    break;
                case 2:
                    return 2;
                    break;
                default:
                    return (ciagfib(zakres - 2) + ciagfib(zakres - 1));
                    break;
            }
        }

        private void ciag_fib_it_Click(object sender, EventArgs e)
        {
            int zakres = Convert.ToInt32(dane.Text);
            zakres = ciagfibIter(zakres);
            dane.Text = Convert.ToString(zakres) + " obliczony iteracyjnie";
        }
        public int ciagfibIter(int zakres)
        {
            int i;
            int last = 1;
            int next = 1;
            int fibWart = 0;
            for (i = 1; i < zakres; i++)
            {
                fibWart = next + last;
                last = next;
                next = fibWart;

            }
            return fibWart;

        }

        private void euklides_Click(object sender, EventArgs e)
        {
            int nwd;
            var liczby = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] dwie_liczby = new int[liczby.Length];
            int i = 0;
            foreach (string c in liczby)
            {
                dwie_liczby[i] = Convert.ToInt32(c);
                i++;
            }

            posortuj(dwie_liczby);

            nwd = euklidesNWD(dwie_liczby, dwie_liczby[1]);
            dane.Text = "Największy wspólny dzielnik to" + Convert.ToString(nwd);
        }

        void posortuj(int[] dwie_liczby)
        {
            int tmp = 0;
            if (dwie_liczby[0] < dwie_liczby[1])
            {
                tmp = dwie_liczby[1];
                dwie_liczby[1] = dwie_liczby[0];
                dwie_liczby[0] = tmp;
            }

        }
        int euklidesNWD(int[] dwie_liczby, int NWD)
        {


            if (dwie_liczby[0] % dwie_liczby[1] == 0)
            {
                return NWD;
            }
            else
            {
                NWD = dwie_liczby[0] % dwie_liczby[1];
                dwie_liczby[0] = dwie_liczby[1];
                dwie_liczby[1] = NWD;
                return euklidesNWD(dwie_liczby, NWD);
            }

        }

        private void merge_sort_Click(object sender, EventArgs e)
        {
            var liczbyString = dane.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            int dlugosc;
            dlugosc = liczbyString.Length;
            int[] nowa = new int[dlugosc];
            for (i = 0; i < dlugosc; i++)
            {
                int tmp = int.Parse(liczbyString[i]);
                nowa[i] = tmp;
            }
            MessageBox.Show("Oto twooje liczby " + string.Join(" ", nowa.ToArray()) + "dlugosc tablicy" + dlugosc);
            dlugosc -= 1;
            dzielSort(nowa, 0, dlugosc);
            dane.Text = string.Join(" ", nowa.ToArray());

        }

        void mergeSort(int[] tabA, int l, int merge, int r)
        {
            int i, j, k;
            int r1 = merge - l + 1;
            int r2 = r - merge;

            int[] tabL = new int[r1];
            int[] tabR = new int[r2];
            for (i = 0; i < r1; i++)
            {
                tabL[i] = tabA[l + i];
            }

            for (j = 0; j < r2; j++)
            {
                tabR[j] = tabA[merge + 1 + j];

            }
            i = 0;
            j = 0;
            k = l;
            while (i < r1 && j < r2)
            {
                if (tabL[i] <= tabR[j])
                {
                    tabA[k] = tabL[i];
                    i++;
                }
                else
                {
                    tabA[k] = tabR[j];
                    j++;
                }
                k++;
            }
            while (i < r1)
            {
                tabA[k] = tabL[i];
                i++;
                k++;
            }
            while (j < r2)
            {
                tabA[k] = tabR[j];
                k++;
                j++;
            }
        }
        void dzielSort(int[] tabA, int i, int j)
        {

            if (i < j)
            {
                int merge = i + (j - i) / 2;

                dzielSort(tabA, i, merge);//lewa połówka
                dzielSort(tabA, merge + 1, j);//prawa połówka
                mergeSort(tabA, i, merge, j);
            }

        }

        private void NWP_Click(object sender, EventArgs e)
        {
            string slowo1;
            string slowo2;
            var slowa = dane.Text.Split(new char[] { ' ' });
            slowo1 = Convert.ToString(slowa[0]);
            slowo2 = Convert.ToString(slowa[1]);
            List<char> slowaNWP1=algorytmNwp(slowo1, slowo2);
            
            dane.Text = string.Join("", slowaNWP1.Reverse<char>().ToArray());
        }



        List<char> algorytmNwp(string slowo1, string slowo2)
        {

            List<char> slowaNWP1 = new List<char>();
            List<char> slowaNWP2 = new List<char>();
            List<char> slowaNWP3 = new List<char>();
            int[,] tab = new int[slowo1.Length + 1, slowo2.Length + 1];


            for (int index = 1; index < slowo1.Length + 1; index++)
            {
                for (int dlugosc = 1; dlugosc < slowo2.Length + 1; dlugosc++)
                {
                    if (slowo1[index - 1] == slowo2[dlugosc - 1])
                    {
                        tab[index, dlugosc] = tab[index - 1, dlugosc - 1] + 1;
                    }
                    else
                    {
                        tab[index, dlugosc] = Math.Max(tab[index, dlugosc - 1], tab[index - 1, dlugosc]);
                    }
                }
            }
            for (int index = 1; index < slowo1.Length + 1; index++)
            {
                for (int dlugosc = 1; dlugosc < slowo2.Length + 1; dlugosc++)
                {
                    Console.Write(tab[index, dlugosc]);
                }
                Console.WriteLine();
            }

            int lewo = slowo2.Length;
            int gora = slowo1.Length;
            while (lewo != 0 && gora != 0)
            {
                if (tab[gora, lewo] == tab[gora, lewo - 1])
                {
                    --lewo;
                    continue;
                }
                else if (tab[gora, lewo] == tab[gora - 1, lewo])
                {
                    --gora;
                }
                else
                {
                    --lewo;
                    --gora;
                    slowaNWP1.Add(slowo1[gora]);
                    slowaNWP3.Add(slowo1[gora]);

                }
            }
            slowaNWP3.Add(' ');
            lewo = slowo2.Length;
            gora = slowo1.Length;
            while (lewo != 0 && gora != 0)
            {
                if (tab[gora, lewo] == tab[gora - 1, lewo])
                {
                    --gora;
                }
                else if (tab[gora, lewo] == tab[gora, lewo - 1])
                {
                    --lewo;
                }
                else
                {
                    lewo--;
                    gora--;
                    slowaNWP2.Add(slowo1[gora]);
                    slowaNWP3.Add(slowo1[gora]);

                }
            }
            // slowaNWP1.Reverse<char>();
            //slowaNWP2.Reverse<char>();
            //Console.WriteLine(slowaNWP1.Reverse<char>().ToArray());
            //Console.WriteLine(slowaNWP2.Reverse<char>().ToArray());
            if (slowaNWP1.Count == slowaNWP2.Count)
                return slowaNWP3;
            else if (slowaNWP1.Count > slowaNWP1.Count)
                return slowaNWP1;
            return slowaNWP2;

        }
    }
}




