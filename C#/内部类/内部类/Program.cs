using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 内部类
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();

            b.show();

            //java写法
            //Base.InterBase01 inter = b.new InterBase01();
            Base.InterBase01 inter = new Base.InterBase01();
            inter.show();

            Console.ReadKey();
        }
    }

    class Base
    {
        string name = "abc";
        int age = 123;

        public void showequal()
        {
            Console.WriteLine("======================");
        }

        private static void showsharp()
        {
            Console.WriteLine("########################");
        }

        //只有将内部类设置为public的时候，mian函数中才可以定义内部了的实例
        public class InterBase01
        {
            String name = "cde";
            int age = 23;
            public void show()
            {
                Console.WriteLine("{0}:{1}", name, age);
                //内部类调用外部类的普通方法的时候也要通过对象调用
                Base b = new Base();
                b.showequal();
                //内部类调用外部内的静态方法不论其访问修饰符是什么都可以通过方法名直接调用
                showsharp();
            }
        }

        public void show()
        {
            //外部类中想要调用内部类的方法，必须通过对象来调用
            InterBase01 inter = new InterBase01();
            inter.show();

            //调用内部类的静态方法，可以直接通过类名调用，静态方法从属于类,但是只可以调用内部类的public和internal的实例和方法
            InterBase02.show();

            Console.WriteLine("{0}:{1}", name, age);
        }

        //将内部类的成员定义成static
        public class InterBase02
        {
            static String name = "cde";
            static int age = 23;
            public static void show()
            {
                Console.WriteLine("{0}:{1}", name, age);
                //内部类静态调用外部类的普通方法的时候也要通过对象调用
                Base b = new Base();
                b.showequal();
                //内部类调用外部内的静态方法不论其访问修饰符是什么都可以通过方法名直接调用
                showsharp();
            }
        }
    }
}
