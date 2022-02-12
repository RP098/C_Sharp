using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michelin_Garda_2021
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logowanie());
        }
        

        public static void ZarzadzanieListaUzytkownikow()
        {
            STAThreadAttribute sTAThread = new STAThreadAttribute();
            sTAThread.IsDefaultAttribute();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zarzadzanie());


        }

       

    }
}
