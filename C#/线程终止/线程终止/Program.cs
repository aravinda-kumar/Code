using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程终止
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Thread myThread = new Thread(ThreadWork.DoWork);
                myThread.Start();               //启动线程myThread，执行DoWork方法
                Thread.Sleep(100);
                Tool.WriteMessage("Main - aborting my thread.", ConsoleColor.Blue, ConsoleColor.White);
                myThread.Abort();               //终止线程myThread
                myThread.Join();                //等待线程myThread结束
                Tool.WriteMessage("Main - ending.", ConsoleColor.White, ConsoleColor.White);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Console.ReadKey();
        }
    }
    public class ThreadWork
    {

        public static void DoWork()
        {
            try
            {
                for (int i = 0; i < 100; i++) 
                {
                    Tool.WriteMessage("Thread - working.", ConsoleColor.Green, ConsoleColor.White);
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException e)
            {
                Tool.WriteMessage("Thread - Caught ThreadAbortException - resetting.", ConsoleColor.Green, ConsoleColor.White);
                Tool.WriteMessage("Thread - Exception message:" + e.Message, ConsoleColor.Red, ConsoleColor.White);

                //--如果调用Thread.ResetAbort()-----
                //1.取消终止线程的请求，并恢复线程，继续执行ResetAbort后面的语句，然后执行catch块之后的语句
                //2.若Catch块之后有Finally块，则执行Finally块，然后执行Finally块后面的语句。

                //----如果没有调用Thread.ResetAbort()----
                //1.finally块在线程终止前执行，finally块之后的语句不会被执行，然后线程终止。

                Thread.ResetAbort();
                Tool.WriteMessage("Thread - ResetAbort", ConsoleColor.Green, ConsoleColor.White);

            }
            finally
            {
                Tool.WriteMessage("Thread - finally blocks were excuted.", ConsoleColor.Green, ConsoleColor.White);
            }
            Tool.WriteMessage("Thread - still alive and working.", ConsoleColor.Green, ConsoleColor.White);
            Thread.Sleep(1000);
            Tool.WriteMessage("Thread - finished working.", ConsoleColor.Green, ConsoleColor.White);
        }
    }

    public static class Tool
    {
        public static void WriteMessage(string message, ConsoleColor writeColor, ConsoleColor backcolor)
        {
            Console.ForegroundColor = writeColor;
            Console.WriteLine(message);
            Console.ForegroundColor = backcolor;
        }
    }
}
