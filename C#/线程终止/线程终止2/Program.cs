using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程终止2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker workObject = new Worker();
            Thread workThread = new Thread(workObject.DoWork);

            workThread.Start();
            Console.WriteLine("main thread: Starting worker thread...");

            Console.WriteLine("========================={0}", workThread.IsAlive);

            //等待线程启动
            while (!workThread.IsAlive) ;
            Thread.Sleep(1);

            workObject.RequestStop();

            workThread.Join();
            Console.WriteLine("main thread: Worker thread has terminated.");
            Console.WriteLine("========================={0}", workThread.IsAlive);

            Console.WriteLine("++++++++++++++++++++++++++++++++");

            Thread thread = new Thread(Test);
            thread.Start();
            Console.WriteLine("========================={0}", thread.IsAlive);
            thread.Join();
            Console.WriteLine("========================={0}", thread.IsAlive);

            Console.WriteLine("按任意键继续......");
            Console.ReadKey();
        }

        static void Test()
        {
            Console.WriteLine("thread test");
        }

    }

    public class Worker
    {
        //线程启动函数
        public void DoWork()
        {
            while(!_shouldStop)
            {
                Console.WriteLine("worker thread: working...");
            }
            Console.WriteLine("worker thread: terminating gracefully.");
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

        private volatile bool _shouldStop;
    }
}
