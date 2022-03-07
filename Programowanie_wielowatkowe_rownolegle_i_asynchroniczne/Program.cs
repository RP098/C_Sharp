using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
namespace Programowanie_wielowatkowe_rownolegle_i_asynchroniczne
{


    class Program
    {

       static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            //Async_Delegate.SyncDelegate();
            //Async_Delegate.AsyncDelegate();
            //Async_Delegate.AsyncDelegate2();
            //Async_Delegate.AsyncCallbackDelegate();
            /*   Thread primaryThread = Thread.CurrentThread;
               primaryThread.Name = "ThePrimaryThread";
               Console.WriteLine("Name of current AppDomain {0}",Thread.GetDomain().FriendlyName);
               Console.WriteLine("Id of cuurent context {0}",Thread.CurrentContext.ContextID);
               Console.WriteLine($"Thread name {primaryThread.Name}");
               Console.WriteLine($"has thread started {primaryThread.IsAlive}");
               Console.WriteLine($"Prioryty Level {primaryThread.Priority}");
               Console.WriteLine($"Thread state {primaryThread.ThreadState}");
           */
            //CreateThread();
            /* addParams addParams = new addParams(2,3);
             Thread threadStart = new Thread(new ParameterizedThreadStart(Add));
             threadStart.Start(addParams);
             threadStart.IsBackground = true;
             waitHandle.WaitOne();
             MessageBox.Show("I'm waiting");
           */
            Program program = new Program();
            program.Concurrency_problem();

            Console.ReadKey();
        }
   
       void Concurrency_problem()
        {
            Console.WriteLine("Synchronizing Threads");
            Print print_ = new Print();
           
                Thread[] threads = new Thread[10];
                for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(new ThreadStart(print_.print_Number));
                    threads[i].Name = string.Format("Worker thread {0}", i);
                }
                foreach (var item in threads)
                {
                    item.Start();
                } 
           
        }
        static void CreateThread()
        {
            Console.WriteLine("Thread app");
            Console.WriteLine("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine().Trim();
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Print print_ = new Print();
            switch (threadCount) 
            {
                case "2": Thread backgroundThread = new Thread(new ThreadStart(print_.print_Number));
                    backgroundThread.Start();
                    break;
                default: Console.WriteLine("Method will be start in current thread");
                    print_.print_Number();
                    break;

            }
            MessageBox.Show("I m busy Work on main thread");

            
        }

        static void Add(object add)
        {
            if (!(add is  addParams))
                return;
            addParams add_ = (addParams)add;
            Console.WriteLine("Id of thread "+ Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(add_.x+ "+" + add_.y + " = "+(add_.x+add_.y));
            Thread.Sleep(2000);
            waitHandle.Set();
          

        }



    }
    }
