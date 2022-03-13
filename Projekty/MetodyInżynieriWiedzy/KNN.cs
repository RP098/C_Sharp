using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyInżynieriWiedzy
{
    class KNN
    {

            static double potegaMin;
            public static int numerKolumnyWartosciDecyzyjnej;
            public static int szerokosc;
            public static int dlugosc;
            public string[,] ZbiorWartosciWzorcowych;
            public string[,] obiekt;
             string[,] metoda1;       //np jedynki albo minusy albo zera w zależności co jest w pierwszym wierszu
             Dictionary<string, List<double>> metoda2;       //np jedynki albo minusy albo zera w zależności co jest w pierwszym wierszu
            public int parametrK;
            public int metryka;     // są 5 metryk takie jakie zostały podane w laborce
                                    //manhatan(minkowski dla m=1)-euklidesowa(minkowski dla m=2) czybyszewa(minkowski m=+infinity 
                                    //ta metryka jest oddzielnie) i ostatnia minkowskiego gdzie m możemy podać dowolne
                                    // za 3 metryki bedzie odpowiadał jeden kod bo po co pisać 3 razy to samo wartośc przekazana -1
                                    // oznacza że koszystamy z czybyszewa a wartość minus dwa to logarytmiczna
        public KNN()
        {

          


        }
        public KNN(int k, int metryka, string[,] ZbiorWartosciWzorcowych, string[,] obiekt)
            {

                this.metryka = metryka;
                this.parametrK = k;
                this.ZbiorWartosciWzorcowych = ZbiorWartosciWzorcowych;
                this.obiekt = obiekt;
              


            }



        double [] zwrocWierszZbioru(string[,] ZbiorWartosciWzorcowych,int i)
        {
            double[] WierszZbioru = new double[KNN.szerokosc-1];
            for (int d=0;d<KNN.szerokosc;d++)
            {
                if (d == KNN.numerKolumnyWartosciDecyzyjnej)
                    continue;
                WierszZbioru[d] = Convert.ToDouble(ZbiorWartosciWzorcowych[i, d].Replace('.',','));


            }

            return WierszZbioru;
        }

        double[] przekonwertujObiekt(string[] obiekt)
        {

            double[] WierszZbioru = new double[KNN.szerokosc - 1];
            for (int d = 0; d < KNN.szerokosc; d++)
            {
                if (d == KNN.numerKolumnyWartosciDecyzyjnej)
                    continue;
                WierszZbioru[d] = Convert.ToDouble(obiekt[d].Replace('.', ','));


            }

            return WierszZbioru;
        }


        public string KlasyfikatorMetodaPierwsza(int k, int metryka, string[,] ZbiorWartosciWzorcowych, string[] obiekt)//k najmniejszych wyników i sprawdzamy czego jest więcej zwraca decyzje w postaci char
            {
          
                try
                {
                    KNN.potegaMin = metryka;
                    KNN kHH = new KNN();
                    double[] obiekt2 = przekonwertujObiekt(obiekt);
                    kHH.metoda1 = new string[KNN.dlugosc, 2];
                    // kHH.ZbiorWartosciWzorcowych.Length / wczytajPlik.dlugosc
                    if (metryka > 0)//zabezpieczyć żeby nie była zerem
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                        {
                        double [] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych,i);
                            
                            kHH.metoda1[i, 0] = Convert.ToString(minkowskiego(Zbior, obiekt2)); 
                            kHH.metoda1[i, 1] = ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej];


                        }


                        kHH.metoda1 = dzielSort(kHH.metoda1, 0, Convert.ToInt32(KNN.dlugosc) - 1);


                    }
                    if (metryka == -1)
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                    {
                        double[] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych, i);
                        kHH.metoda1[i, 0] = Convert.ToString(czybyszewa(Zbior, obiekt2));
                            kHH.metoda1[i, 1] = ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej];


                        }

                        kHH.metoda1 = dzielSort(kHH.metoda1, 0, Convert.ToInt32(KNN.dlugosc) - 1);

                    }
                    if (metryka == -2)
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                    {
                        double[] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych, i);
                        kHH.metoda1[i, 0] = Convert.ToString(logarytm(Zbior, obiekt2));
                            kHH.metoda1[i, 1] = ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej];


                        }

                        kHH.metoda1 = dzielSort(kHH.metoda1, 0, Convert.ToInt32(KNN.dlugosc) - 1);
                    }


                    Dictionary<string, int> slownik = new Dictionary<string, int>();


                    for (int i = 0; i < k; i++)
                    {
                        try
                        {
                            slownik[kHH.metoda1[i, 1]] = 0;
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        slownik[kHH.metoda1[i, 1]]++;

                    }
                    string wartoscDecyzyjna = " ";
                    int decyzja = 0;
                    foreach (var i in slownik.Keys)
                    {
                        if (decyzja <= slownik[i])
                        {
                            decyzja = slownik[i];
                            wartoscDecyzyjna = i;
                        }
                    }
                    int ile = 0;
                    foreach (var i in slownik.Keys)
                    {
                        if (decyzja == slownik[i])
                            ile++;
                    }

                    if (ile < 2)
                        return wartoscDecyzyjna;
                    else
                        return "N";




                }
                catch
                {
                    return "N";
                }
            }


            public string KlasyfikatorMetodaDruga(int k, int metryka, string[,] ZbiorWartosciWzorcowych, string[] obiekt)//k najmniejszych wyników i sprawdzamy czego jest więcej zwraca decyzje w postaci char
            {
            KNN.potegaMin = metryka;
            string[,] sumNajmniejszych;
                try
                {
                double[] obiekt2 = przekonwertujObiekt(obiekt);
                KNN kHH = new KNN();
                    kHH.metoda2 = new Dictionary<string, List<double>>();

                    for (int i = 0; i < KNN.dlugosc; i++)
                    {
                    if (!kHH.metoda2.ContainsKey(ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej]))
                        kHH.metoda2.Add(ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej], new List<double>());




                }


                if (metryka > 0)//zabezpieczyć żeby nie była zerem
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                        {
                        double[] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych, i);
                        kHH.metoda2[ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej]].Add((minkowskiego(Zbior, obiekt2)));



                        }





                    }
                    if (metryka == -1)
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                    {
                        double[] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych, i);
                        kHH.metoda2[ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej]].Add((czybyszewa(Zbior, obiekt2)));


                        }


                    }
                   if(metryka == -2)
                    {
                        for (int i = 0; i < KNN.dlugosc; i++)
                        {
                        double[] Zbior = zwrocWierszZbioru(ZbiorWartosciWzorcowych, i);
                        kHH.metoda2[ZbiorWartosciWzorcowych[i, KNN.numerKolumnyWartosciDecyzyjnej]].Add((logarytm(Zbior, obiekt2)));


                        }

                    }

                    double suma;
                    int rozmiar = 0;
                    foreach (var d in kHH.metoda2.Keys)
                    {
                        rozmiar++;
                        kHH.metoda2[d].Sort();
                    }
                    int c = 0;
                    sumNajmniejszych = new string[rozmiar, 2];
                    foreach (var d in kHH.metoda2.Keys)
                    {
                        suma = 0.0;
                        for (int i = 0; i < k; i++)
                        {
                            suma += kHH.metoda2[d][i];


                        }

                        sumNajmniejszych[c, 0] = suma.ToString();
                        sumNajmniejszych[c++, 1] = d;


                    }

                    sumNajmniejszych = dzielSort(sumNajmniejszych, 0, rozmiar - 1);



                    if (Convert.ToDouble(sumNajmniejszych[0, 0]) < Convert.ToDouble(sumNajmniejszych[1, 0]))
                        return sumNajmniejszych[0, 1];
                    else
                        return "N";


                }
                catch
                {
                    return "N"; // bo np ktoś poda za duże K to wtedy program nie wie co zrobić
                }
            }



            public double minkowskiego(double[] ZbiorWartosciWzorcowych, double[] obiekt) // oszczędność kodu dla m==1 jest manhattan dla m==2 euklidesowa dla m limes infiniti czybyszewa
            {
               
                double suma;
                suma = 0.0;
                int d = 0;
                for (int i = 0; i < KNN.szerokosc-1; i++)
                {
                    
                
                    
                    double pom = Math.Abs(obiekt[ d] - ZbiorWartosciWzorcowych[ i]);
                    suma += Math.Pow(pom, KNN.potegaMin);
                    d++;
                }
                suma = Math.Pow(suma, (1 / KNN.potegaMin));
                return suma;
            }

            public double logarytm(double[] ZbiorWartosciWzorcowych, double[] obiekt)
            {
         
                double suma;
                suma = 0.0;
                int d = 0;
                for (int i = 0; i < KNN.szerokosc-1; i++)
                {
                   
                 
                    double pom = Math.Abs(Math.Log(Convert.ToDouble(obiekt[ d])) - Math.Log(Convert.ToDouble(ZbiorWartosciWzorcowych[ i])));
                    suma += pom;
                    d++;
                }

                return suma;
            }
            public double czybyszewa(double[] ZbiorWartosciWzorcowych, double[] obiekt)
            {
            
                double suma = 0.0;

                int d = 0;


                for (int i = 0; i < KNN.szerokosc-1; i++)
                {
                   
                         
                    suma = suma < Math.Abs(obiekt[ d] - ZbiorWartosciWzorcowych[ i]) ? Math.Abs(obiekt[d]- ZbiorWartosciWzorcowych[ i] ) : suma;
                    d++;
                }



                return suma;
            }

            void mergeSort(string[,] tabA, int l, int merge, int r)
            {
                int i, j, k;
                int r1 = merge - l + 1;
                int r2 = r - merge;

                string[,] tabL = new string[r1, 2];
                string[,] tabR = new string[r2, 2];
                for (i = 0; i < r1; i++)
                {
                    tabL[i, 0] = tabA[l + i, 0];
                    tabL[i, 1] = tabA[l + i, 1];
                }

                for (j = 0; j < r2; j++)
                {
                    tabR[j, 0] = tabA[merge + 1 + j, 0];
                    tabR[j, 1] = tabA[merge + 1 + j, 1];
                }
                i = 0;
                j = 0;
                k = l;
                while (i < r1 && j < r2)
                {
                    if (Convert.ToDouble(tabL[i, 0].Replace('.', ',')) <= Convert.ToDouble(tabR[j, 0].Replace('.', ',')))
                    {
                        tabA[k, 0] = tabL[i, 0];
                        tabA[k, 1] = tabL[i, 1];
                        i++;
                    }
                    else
                    {
                        tabA[k, 0] = tabR[j, 0];
                        tabA[k, 1] = tabR[j, 1];
                        j++;
                    }
                    k++;
                }
                while (i < r1)
                {
                    tabA[k, 0] = tabL[i, 0];
                    tabA[k, 1] = tabL[i, 1];
                    i++;
                    k++;
                }
                while (j < r2)
                {
                    tabA[k, 0] = tabR[j, 0];
                    tabA[k, 1] = tabR[j, 1];
                    k++;
                    j++;
                }
            }
            public string[,] dzielSort(string[,] tabA, int i, int j)
            {

                if (i < j)
                {
                    int merge = i + (j - i) / 2;

                    dzielSort(tabA, i, merge);//lewa połówka
                    dzielSort(tabA, merge + 1, j);//prawa połówka
                    mergeSort(tabA, i, merge, j);
                }
                return tabA;
            }

        public int JakieKsprawdzanieSumNajmniejszych(string[,] zbiorWartosci, long dlugosc, int numerKolumnyWartosciDecyzyjnej)
        {

            Dictionary<string, int> slownik = new Dictionary<string, int>();

            for (int i = 0; i < dlugosc; i++)
            {
                try
                {
                    slownik[zbiorWartosci[i, numerKolumnyWartosciDecyzyjnej]] = 0;
                }
                catch
                {
                    continue;
                }
            }

            for (int i = 0; i < dlugosc; i++)
            {
                slownik[zbiorWartosci[i, numerKolumnyWartosciDecyzyjnej]]++;
            }
            List<int> k = new List<int>();
            foreach (var z in slownik.Keys)
            {
                k.Add(slownik[z]);
            }
            k.Sort();

            return k[0];
        }




    }
    }

