using System;
using System.Linq;
using System.Net.Http;
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

            #region 1.14
            //Task[] task = new Task[3];

            //task[0] = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("1");
            //    return 1;
            //});
            //task[1] = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("2");
            //    return 1;
            //});
            //task[2] = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("3");
            //    return 1;
            //});

            //Task.WaitAll(task);
            #endregion

            #region 1.15

            //Task<int>[] tasks = new Task<int>[3];

            //tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            //tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            //tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            //while(tasks.Length > 0)
            //{
            //    int i = Task.WaitAny(tasks);
            //    Task<int> completedTask = tasks[i];
            //    Console.WriteLine(completedTask.Result);
            //    var temp = tasks.ToList();                
            //    temp.RemoveAt(i);
            //    tasks = temp.ToArray();
            //}
            #endregion

            #region 1.16
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}
            //Thread.Sleep(2000);
            //Console.WriteLine("Start");
            //Parallel.For(0, 10, (i) =>
            //  {
            //      Console.WriteLine(i);
            //      Thread.Sleep(1000);
            //  });

            //int[] myArray = {0,1,2,3,4,5,6,7,8,9 };
            //foreach(int x in myArray)
            //{
            //    Console.WriteLine(x);
            //    Thread.Sleep(1000);
            //}
            //Parallel.ForEach(myArray, (i) =>
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //});
            #endregion

            #region 1.18 async and wait
            //string result = DownloadContent().Result;
            //Console.WriteLine(result);
            #endregion

            #region 1-35



            #endregion
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}