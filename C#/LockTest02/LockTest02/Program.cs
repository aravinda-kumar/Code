using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//该实例是一个线程中Lock的经典用法，使得到的balance不为负数
//同时初始化是个线程，启动十个，但由于加锁，能够启动调用withdraw方法的可能只能是其中几个

namespace LockTest02
{
    class Account
    {
        private Object thisLock = new object();
        private Object thisLock1 = new object();
        int balance;
        Random r = new Random();
        public Account(int initial)
        {
            balance = initial;
        }
        int WithDraw(int amount)
        {
            if (balance < 0)
            {
                throw new Exception("负的balance");
            }
            //确保只有一个线程使用资源
            //一个进入临界状态使用了对象互斥锁
            //10个启动了的线程不能全部执行该方法
           lock (thisLock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine("---------------------------:"+System.Threading.Thread.CurrentThread.Name + "----------------------------");
                    Console.WriteLine("调用withdraw之前的balance：{0}", balance);
                    Console.WriteLine("把Amount输入withdraw      ：{0}",amount);
                    //如果没有加对象互斥锁
                    //则可能10个线程都执行下面的减法
                    //加减法所耗时间片段非常小
                    //可能多个线程同时执行
                    //出现负数。
                    balance -= amount;
                    Console.WriteLine("调用withdraw之后的balance：{0}", balance);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void DoTransaction()
        {
           // lock (thisLock1)
            {
                for (int i = 0; i < 5; i++)
                {
                    WithDraw(r.Next(1, 100));
                }
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread[] threads = new System.Threading.Thread[10];
            Account acc = new Account(10000);
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(acc.DoTransaction));
                threads[i] = t;
                threads[i].Name = "Thread" + i.ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.ReadKey();
        }
    }
}
