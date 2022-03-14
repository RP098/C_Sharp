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
using System.IO;
namespace ProgramowanieRownolegle
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private  void ProccessFiles()
        {
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancellationToken.Token;
            parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            string[] files = Directory.GetFiles(@"C:\Users\Asus\Desktop\zdjecia", "*.jpg",SearchOption.AllDirectories);
            string newDir = @"C:\Users\Asus\Desktop\ModifiedPictures";
            Directory.CreateDirectory(newDir);
            try
            {
                Parallel.ForEach(files, parallelOptions,currentFile =>
                 {
                     string filename = Path.GetFileName(currentFile);
                     using (Bitmap bitmap = new Bitmap(currentFile))
                     {
                         bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                         bitmap.Save(Path.Combine(newDir, filename));
                         textBox1.Invoke((Action)delegate
                       {
                         textBox1.Text = string.Format($"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}");
                     });
                     }

                 }
             );
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private  void Read_And_Processing_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(()=>{
            ProccessFiles();
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }
    }
}
