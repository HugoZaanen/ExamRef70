using System;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-35 Accessing shared data in a multithreaded application
            //int n = 0;

            //object _lock = new object();

            //Task myTask = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        lock(_lock)
            //        n++;
            //    }
            //});

            //for (int i = 0; i < 1000000; i++)
            //{
            //    lock(_lock)
            //    n--;
            //}

            //myTask.Wait();
            //Console.WriteLine(n);
            #endregion

            #region 1-37 Creating a deadlock
            //object lockA = new object();
            //object lockB = new object();

            //Task myTask = Task.Run(() =>
            //{
            //    lock(lockA)
            //    {
            //        lock(lockB)
            //        {
            //            Console.WriteLine("Locked A and B");
            //        }
            //    }
            //});

            //lock(lockB)
            //{

            //    lock(lockA)
            //    {
            //        Console.WriteLine("Locked B and A");
            //    }
            //}
            //myTask.Wait();
            #endregion

            #region 1-40 Using the Interlocked class
            //int n = 0;
            //Task myTask = Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {

            //        Interlocked.Increment(ref n);
            //    }
            //});

            //for (int i = 0; i < 1000000; i++)
            //{                
            //    Interlocked.Decrement(ref n);
            //}
            //myTask.Wait();
            //Console.WriteLine(n);
            #endregion

            #region 1-42 Using a CancellationToken
            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //CancellationToken token = cancellationTokenSource.Token;

            //Task myTask = Task.Run(() =>
            //{
            //    while(!token.IsCancellationRequested)
            //    {
            //        Console.Write("*");
            //        Thread.Sleep(1000);
            //    }

            //    token.ThrowIfCancellationRequested();

            //},token);

            //try
            //{
            //    Console.WriteLine("Press enter to stop the task");
            //    Console.ReadLine();
            //    cancellationTokenSource.Cancel();
            //    myTask.Wait();
            //}
            //catch(AggregateException e)
            //{
            //    Console.WriteLine(e.InnerExceptions[0].Message);
            //}
            //Console.WriteLine("Press enter to end the program");
            //Console.WriteLine();
            #endregion

            #region 1-45 Setting a timeout on a Task
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(5000);
            });

            int index = Task.WaitAny(new Task[] { longRunning },2000);
            if(index == -1)
            {
                Console.WriteLine("Task timed out");
            }
            #endregion
        }
    }
}
