using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

namespace Video
{
    class Program
    {
        static ThreadLocal<double> _Count = new ThreadLocal<double>(() => 0.01134);
        public static double Count
        {
            get { return _Count.Value; }
            set { _Count.Value = value; }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Decrement);
            thread.Start();

            for (double i = 0; i < short.MaxValue; i++)
                Count++;
            thread.Join();
            Console.WriteLine($"Main Count={Count}");

            Console.ReadKey();
        }
        static void Decrement()
        {
            Count = -Count;
            for (double i = 0; i < short.MaxValue; i++)
                Count--;
            Console.WriteLine($"Decrement Count={Count}");
        }
    }
}