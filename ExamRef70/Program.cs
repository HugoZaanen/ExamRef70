using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70
{
    class Program
    {
        #region
        /// <summary>
        /// 1.8 ! Task class ! method example runs with ! action : !
        /// </summary>
        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write('*');
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region
            //Task t = Task.Run(() => {
            //    for(int i = 0;i < 100;i++)
            //    {
            //        Console.Write('*');
            //    }
            //});
            //t.Wait();
            #endregion

            #region
            //Task t = Task.Run(action:ThreadMethod);
            //t.Wait();
            #endregion

            #region 1.9
            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //}).ContinueWith((i) =>
            //{
            //    return i.Result * 2;
            //});

            //t = t.ContinueWith((i) =>
            //{
            //    return i.Result * 2;
            //});
            #endregion

            #region 1.10
            //Task<int> t = Task.Run(() =>
            //{               
            //    return 42;
            //});
            //t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Completed");
            //}, TaskContinuationOptions.OnlyOnRanToCompletion);

            //Console.WriteLine(t.Result);
            #endregion

            Task[] task = new Task[3];

            task[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            task[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 1;
            });
            task[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 1;
            });
        }
    }
}