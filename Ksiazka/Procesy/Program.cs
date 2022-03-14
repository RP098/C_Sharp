using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Procesy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListAllRunningProcesses();
            Console.WriteLine("Give me process ID");
            try
            {
                EnumThreadForPid(int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Process iExplorerProcessStart = null;
            try
            {
                //iExplorerProcessStart = Process.Start("MicrosoftEdge.exe", "www.facebook.com");
                ProcessStartInfo startInfo = new ProcessStartInfo("MicrosoftEdge.exe", "www.facebook.com");
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                iExplorerProcessStart = Process.Start(startInfo);
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }

        static void ListAllRunningProcesses()
        {
            Console.WriteLine("List process in your PC");
            var runningProces = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            foreach (var item in runningProces)
            {
                string info = string.Format($"-> PID: {item.Id} \tName{item.ProcessName}");
                Console.WriteLine(info);
            }
            Console.WriteLine("*********************************");
        }

        static void EnumThreadForPid(int pId)
        {
            Process theProcess = null;
            try
            {
                theProcess = Process.GetProcessById(pId);
                Console.WriteLine($"Here are the threads used by{theProcess.ProcessName}");
                ProcessThreadCollection threadCollection = theProcess.Threads;
                foreach (ProcessThread item in threadCollection)
                {
                    Console.WriteLine(string.Format($"->Thread ID {item.Id} \tStart Time {item.StartTime.ToShortTimeString()} \tPrority {item.PriorityLevel} "));
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
