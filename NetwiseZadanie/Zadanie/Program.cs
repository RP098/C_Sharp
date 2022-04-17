using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadWebText;
using File_manager;
namespace Zadanie
{
    class Program
    {
        static IDownload download_ = new DownloadTextFromWeb();
        static ICreate create_ = new CreateFileTxt();
        static IWrite write_ = new WriteToFileTxt();
        static IRead read_ = new ReadFileTxt();
        static void Main(string[] args)
        {
            Download download = new Download(download_);
            string textDownload =download.Download_text();
            Create create = new Create(create_);
            create.CreateFile();
            Write write = new Write(write_);
            write.WriteToFile(textDownload);
            Read read = new Read(read_);
            Console.WriteLine(read.ReadFile());
            
            Console.ReadLine();
        }
    }
}
