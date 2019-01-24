using System;
using System.Diagnostics;
namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            OldFunc();
            
        }
        [Obsolete("This function is old")]
        static void OldFunc()
        {
            Console.WriteLine("This is a old Func");
        }
    }
}
