# override和new的区别
## override
1. override是派生类用来重写基类中方法的；
2. override不能重写非虚方法和静态方法；
3. override只能重写用virtual、abstract、override修饰的方法；
4. 不能使用修饰符 new、static、virtual 或 abstract 来修改 override 方法。

## new
1. new是派生类用来隐藏基类中的方法的；也就是说在派生类中“看不到”基类中的方法；
2. 如果要在派生类中隐藏（不是重写）基类中的方法，而没有使用new关键字，编译时会出现一个警告，提示如果是要隐藏基类中的方法，请使用new关键字；
3. 派生类可以隐藏基类中的虚方法，也可以隐藏基类中的普通方法。
4. 如果在派生类中用private来修饰new 方法，那么只在该派生类中隐藏了基类中的方法，在该派生类之外，相当于没有隐藏基类中的方法；
5. 如果在派生类中隐藏了基类中的方法，在该派生类的派生类中，将延续对该派生类对基类方法的隐藏。

```cs
    class A
    {
        public virtual void Func()
        {
            Console.WriteLine("function in class A");
        }
    }
    class B:A
    {
        public override void Func()
        {
            Console.WriteLine("function in class B");
        }
    }
    class C:B
    {
        public override void Func()
        {
            Console.WriteLine("function in class C");
        }
    }
    class D:A
    {
        public new void Func()
        {
            Console.WriteLine("function in class D");
        }
    }
    class E:D
    {
        public new void Func()
        {
            Console.WriteLine("function in class E");
        }
    }
    class F:A
    {
        private new void Func()
        {
            Console.WriteLine("function in class F");
        }
        public void ShowFunc(){Func();}
    }
    class G:F{}
```
例如在以上的代码中B，C覆写了A的方法，D，E隐藏了A的方法，F也隐藏了A的方法，但是它是通过private方式隐藏，G继承了F。
如果通过以下方式给A的实例进行赋值
```cs
	A a = new A();
	A b = new B();
	A c = new C();
	A d = new D();
	A e = new E();
	A f = new F();
	A g = new G();
```
输出为
```cs
	a.Func():function in class A
	b.Func():function in class B
	c.Func():function in class C
	d.Func():function in class A
	e.Func():function in class A
	f.Func():function in class A
	g.Func():function in class A
```
解释：
	从结论中可以明显的看到，覆写了A中方法的实例调用的是其自身中的方法，对于隐藏的类来说仍然调用的是A中的方法。
如果运行一下代码
```cs
	A a = new A();
	B b = new B();
	C c = new C();
	D d = new D();
	E e = new E();
	F f = new F();
	G g = new G();
```
结果是：
```cs
	a.Func():function in class A
	b.Func():function in class B
	c.Func():function in class C
	d.Func():function in class D
	e.Func():function in class E
	f.Func():function in class A
	g.Func():function in class A
```
	f和g显示的仍然是A中的方法的原因是F中对A中方法的隐藏的访问修饰符是private，所以在外部这个new方法是是不可见的；
	通过以下代码可以获得
```cs
	f.ShowFunc();
```
	显示的结果就是function in class F；
