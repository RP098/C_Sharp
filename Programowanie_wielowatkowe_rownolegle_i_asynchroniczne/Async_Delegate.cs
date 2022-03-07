using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Programowanie_wielowatkowe_rownolegle_i_asynchroniczne
{
    public delegate int BinaryOp(int x, int y);
    class Async_Delegate
    {
        static bool isDone = false;
       public static void SyncDelegate()
        {
            Console.WriteLine("**** Sync Delegate Review ****");
            Console.WriteLine("Main() invoked on thread " + Thread.CurrentThread.ManagedThreadId.ToString());
            BinaryOp binary = new BinaryOp(Add);
            int answer = binary(10, 10);
            Console.WriteLine("10+10 is {0}", answer);
        }
        public static void AsyncDelegate()
        {
            Console.WriteLine("**** Async Delegate Review ****");
            Console.WriteLine("Main() invoked on thread " + Thread.CurrentThread.ManagedThreadId.ToString());
            BinaryOp binary = new BinaryOp(Add);
            IAsyncResult asyncResult = binary.BeginInvoke(10, 10, null, null);
            Console.WriteLine("Doing more work ");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            int answer = binary.EndInvoke(asyncResult);
            Console.WriteLine("10+10 is {0}", answer);

        }
        public static void AsyncDelegate2()
        {
            Console.WriteLine("**** Async Delegate Review ****");
            Console.WriteLine("Main() invoked on thread " + Thread.CurrentThread.ManagedThreadId.ToString());
            BinaryOp binary = new BinaryOp(Add);
            IAsyncResult asyncResult = binary.BeginInvoke(10, 10, null, null);
            Console.WriteLine("Doing more work ");
            int i = 0;
            while (!asyncResult.IsCompleted)
            {
                Console.Write("Please wait");
                Console.WriteLine(i++);
                Thread.Sleep(1000);
            }
            int answer = binary.EndInvoke(asyncResult);
            Console.WriteLine("10+10 is {0}", answer);

        }
        public static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        public static void AsyncCallbackDelegate()
        {
            Console.WriteLine("Async Callback Delegate Example");
            Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            BinaryOp binary = new BinaryOp(Add);
            IAsyncResult asyncResult = binary.BeginInvoke(10, 10, new AsyncCallback(AddComplete), "Thanks you for adding this number");

            while (!isDone)
            {
                Console.WriteLine("Please wait");
                Thread.Sleep(1000);
            }

        }

        public static void AddComplete(IAsyncResult asyncResult)
        {
            Console.WriteLine("Add Complete () invoked on thread{0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your addition is complete");
            isDone = true;
            AsyncResult async = (AsyncResult)asyncResult;
            BinaryOp binaryOp = (BinaryOp)async.AsyncDelegate;
            string message_ = (string)asyncResult.AsyncState;
            int answer = binaryOp.EndInvoke(asyncResult);
            Console.WriteLine("10+10 is {0}", answer);
            Console.WriteLine(message_);

        }
    }
}
