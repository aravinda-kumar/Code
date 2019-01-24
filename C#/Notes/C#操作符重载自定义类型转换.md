# C#操作符重载自定义类型转换
## 运算操作符重载
1. 四则运算操作符重载
2. 条件逻辑运算符不可以被重载(||、&&)，但是可以重载按位操作符(|、&)
3. boolen运算符重载
- 语法：public static \[return-type] operator \[op](parameters);

## 类型转换操作符重载
1. 主要有隐式转换和显式转换(implicit explicit)
2. 此时operator后面跟的是准换后的类型而不是代表着转换的操作符
- 语法：public static\[implicit/explicit] operator \[return-type](parameters);

## 示例代码
```cs
class Complex
{
	public Complex(int real=0, int image=0)
	{
		Real = real;
		Image = image;
	}
	public int Real { get; set; }
	public int Image { get; set; }
	//定义一个类来表示复数，复数主要包括实部和虚部
	public static Complex operator +(Complex c1, Complex c2)
	{
		//由于系统默认的加法运算时不可以对自定义类复试进行操作的，
		//但在实际的操作中复数是可以被相加的，
		//所以需要在类中对加法运算符“+”进行重载
		//相加的两个操作数都是类Complex的实例，所以返回值也是累Complex的实例。
		Complex Result = new Complex();
		Result.Real = c1.Real + c2.Real;
		Result.Image = c1.Image + c2.Image;
		return Result;
	}
	public static Complex operator -(Complex complex)
	{
		//此处的“-”操作符是负数操作符，并不是传统的四则里面的相减操作符。
		return new Complex(complex.Real, -complex.Image);
	}
	public static bool operator true(Complex complex)
	{
		//boolen运算符true和false必须同时重载
		//它们只能用于表逻辑判断的场景例如
		//Complex complex = new Complex(1,1);
		//if(complex)
		//这里if里面的complex在运算中就会返回true
		//但是如果想在Console.WriteLine(complex)中直接输出true或者false是不可以的
		//程序只会输出类型的名称
		return complex.Real > 0;
	}
	public static bool operator false(Complex complex)
	{
		//解释同true的重载
		return complex.Real <= 0;
	}
	public static explicit operator int(Complex complex)
	{
		//此处代表可可以将Complex类型的实例显式转换成int
		//Complex complex = new Complex(1,3);
		//int real = (int)complex;
		//Console.WriteLine(real);
		//our: 1
		return complex.Real;
	}
	public static implicit operator Complex(int real)
	{
		//此处代表可可以将int类型的实例隐式转换成Complex
		//int real = 12;
		//Complex complex = real;
		//complex.Display()
		//our: 12+0i
		return new Complex(real, 0);
	}
	public void Display()
	{
		//以(a+bi)的形式输出:
		Console.WriteLine($"{Real} + {Image}i");
	}
}
```