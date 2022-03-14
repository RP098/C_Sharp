using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
namespace MyEBookReader
{
    public partial class Form1 : Form
    {
        static string theEbook;
        public CancellationTokenSource cancellationToken = new CancellationTokenSource(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += (s, eArgs) => // webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted ;
            {
                theEbook = eArgs.Result;
                textBoxOknoGlowne.Text = theEbook;
            };
            webClient.DownloadStringAsync(new Uri("https://www.gutenberg.org/files/11/11-0.txt"));
        }

        private void buttonGetStats_Click(object sender, EventArgs e)
        {
            string[] tenMostCommon=null;
            string theLongest=" ";
            string[] words = theEbook.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
            Parallel.Invoke(() =>
            {
                 tenMostCommon = FindTenMostCommon(words);
            },
             () =>
              {
                theLongest = FindTheLongestWords(words);
            });
             
            StringBuilder bookStats = new StringBuilder("Ten Most Common Words");
            foreach (var item in tenMostCommon)
            {
                bookStats.AppendLine(item);
            }
            bookStats.AppendFormat("Longest word is: {0}", theLongest);
            bookStats.AppendLine();
            MessageBox.Show(bookStats.ToString(),"Book info");
        }

        private string[] FindTenMostCommon(string[] words)
        {
            string[] commonWOrds = null;
            try
            {
                var TenMost = from word in words.AsParallel()
                              where word.Length > 3
                              group word by word into g
                              orderby g.Count() descending
                              select g.Key;
                commonWOrds = (TenMost.Take(10)).ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
          
            return commonWOrds;
           
        }
        private string FindTheLongestWords(string[] words)
        {
            return (from w in words orderby w.Length descending select w).FirstOrDefault();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }
        //\u000A new line
        /*private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
}
