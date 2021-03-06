# JAVA笔记

- 变量名必须以字母，下划线，美元符开头
- 局部变量在使用前要么被初始化要被被赋值，否则不可以被使用
- 成员变量会自动初始化，成员变量从属于对象
- 静态变量，也叫类变量，从属于类，生命周期伴随类的始终。静态变量也会自动赋初值。
- 常量(Constant)
	- 关键字 final
	- 常量被初始化后，值不可以发生改变，也成符号常量
	- 命名规则 -- 大写字母和下划线
- 基本数据类型
	- 数值型 -- byte int short long float double
	- 字符型 -- char
	- 布尔型 -- booleam

	- 浮点数不可以用于数值比较
	- java的char采用的是Unicode，所以char里面可以装载汉字，和c/c++不一样
	- 布尔类型中在内存中占的是一位(bit)，不是一个字节
- 运算符规则
	- 整数运算
		- 如果两个操作数有一个为long，则结果也为long
		- 如果没有long，结果为int，即使操作数全为short, byte结果也是int
		- 数据较大的时候运算的时候，可以把第一个数据类型转换为long
	- 浮点运算
		- 如果两个操作数中有一个为double，则结果为double
		- 只有两个操作数都为float，则结果才是float
	- 取模
		- 符号取决于左操作数
	- 复合运算符
		- a*=b+3 => a = a*(b+3)
	- 关系运算符的结果是true和false
		- 逻辑与-短路与；逻辑或-短路或
			- 逻辑与和逻辑或不管怎么样都会把条件都运行一遍
			- 短路与只要碰到一个假就停止运算
			- 短路或只要碰到一个真就停止运算
	- &和|既可以表示逻辑与逻辑或也可以表示按位与和按位或
		- 如果两侧是布尔类型则是逻辑与和逻辑或
		- 如果两侧是整数类型则是按位与和按位或
	- 字符串连接符 +
		- 运算符两侧只要有一个为字符串，系统就会自动将另一个操作数变成字符串进行连接
		- 这个运算符针对是String，不是char
- 自动类型转换
	- 容量小的可以自动转换为容量大的。
		- 容量指定是数字的大小范围，不是字节数
	- 整型常量可以直接赋值给byte, short, char类型，只要不超过其表示范围，赋值给long的时候要注意int的范围
	- 注意double类型和float类型的表示范围要比long大
- 强制类型转换
	- (type)num
- 使用Scanner获取键盘输入
	- import java.util.Scanner;
- 随机数
	- Math.random();
	- 返回0~1之间的随机数，不包含1
- 类的定义方式
	- 每一个源文件必须有且只有一个public class，并且类名和文件名保持一致
- JAVA虚拟机的内存可以分为:
	- 栈stack
	- 堆heap
	- 方法区method area -- 也叫静态区，方法区在堆里面
- 构造器
	- 通过new关键字调用
	- 构造器的方法名必须和类名保持一致
	- 构造器有返回值，但不可以定义返回值类型
	- 如果没有定义构造器，编译器会自动添加空构造
	- 构造器的第一句都是super(); 不论是否写入, 原理就是子类先调用父类的构造函数
- 垃圾回收机制(Garbage Collection)
	- 发现无用的对象
	- 回收无用的对象
- JAVA中的this指的是当前对象(并非当前对象指针)
	- this可以重载构造器
	```java
	public class Stu{
		Stu(int a, int b){
			this.a = a;
			this.b = b;
		}
		Stu(int a, int b, int c){
			this(a, b);
			this.c = c;
		}
	}
	```
	- this不能用于静态方法中
- static关键字
	- static修饰的成员变量和方法从属于类，和对象无关。但是可以通过对象调用，但是会报警告
	- 静态初始化块用来初始化类
	- 用static修饰的语句块，类初始化的时候执行，静态块中只能使用静态变量，语句块在构造器之前执行
- JAVA中所有的都是值传递，传递引用类型的时候传递的是对象的地址
- 包机制是JAVA中管理类的重要手段。开发中，我们会遇到大量同名的类，通过包我们很容易解决类重名的问题，也可以实现对类的有效管理，包对于类，相当于文件夹对于文件的作用。
	- 关键字package
	- 导入包关键字 -- import
	- 通常是类的第一句非注释性的语言
	- 写项目的时候一定要加包，不要使用默认包
	- 多包的时候出现重名，就把其所在位置写具体，相当于绝对路径
	- 静态导入import static pkg.pkg;
- 继承
	- 关键字 extends
	- java只有单继承
	- java中类没有多继承，接口可以多继承
	- 子类继承父类，构造方法不继承，其他方法都可以继承，但是不一定可以使用，比如私有成员
	- 一个类默认继承java.lang.object
- instanceof运算符
	- instanceof是二元运算符，左边是对象，右边是类，当对象是右边的类或者子类所创建的对象的时候，返回true，否则返回false
	- instance instanceof class
- 方法的重写 -- override
	- 子类通过重写父类的方法，子类的行为可以替换父类的行为
	- 返回值类型，子类要小于等于父类，即父类的返回类型是子类的返回类型的同类或者父类及以上
	- 子类重写父类的方法的时候前面最好加上@override，这样编译器会检测要重写的方法到底是不是父类的方法，不是的话则报错，如果不写，编译器不会进行检查，如果不是父类的方法，编译器默认认为这是一个新的方法。
- ==
	- 对于基本数据类型看数值是否相等
	- 对于引用数据类型看地址是否相等
- equals()
	- 重写判断“对象内容是否相等” -- 该方法一般需要重写
- super
	- 是直接父类的引用，可以通过super调用父类中被重写的内容
- java访问修饰符
	- private		-- 本类可见
	- default		-- 本类可见，同一个包中可见
	- protected		-- 本类可见，同一个包中可见，其他包中的子类内部可见，子类对象不可调用
	- public		-- 所有都可见
	- 类的属性一般使用private，可提供get/set方法，对于Boolean属性get变为is
	- 方法一般使用public
- 对象的转型
	- 父类的引用可以指向子类的实例
	- 指向子类的实例的父类的引用想要使用子类的方法，必选强制转回成子类 -- (class)obj
- final关键字
	- 修饰变量 -- 这个类变成了常量
	- 修饰方法 -- 这个方法不可以被重写，但是可以被重载
	- 修饰类 -- 这个类不可以被继承
- for-each()循环 -- 是只读操作
	- for(type name : varArr)
- 抽象类
	- 是一种模板模式，为所有子类提供一个通用的模板，子类可以在这个模板的基础上进行扩展
	- 抽象类中的抽象方法，在子类中必须重写
	- 抽象类可以继承抽象类
	- 抽象类中可以存在普通方法
	- 抽象类不可以实例化
	- 抽象类可以有构造函数，但是该构造函数值可以被基类调用，不可以使用new关键字
- 接口
	- 接口里面只存在常量和抽象方法
	- 关键字 -- implements
	- 接口中的常量，默认是public static final
	- 接口中的方法，默认是public abstract
	- 常量调用 -- 接口名.常量名
	- 接口可以呈现多继承
	- 接口不可以常见对象
	- 接口之间可以继承
	- interface本身也可以被访问修饰符修饰
- 回调 -- callback
- 内部类，在另一个类的里面定义的类
	- 只能让外部类直接访问，不允许同一包中的其他类直接访问
	- 内部类可以直接外部类的私有属性
	- 由于内部类提供了更好的封装性，并且可以很方便的访问外部类的属性，所以通常内部类只为所在外部类提供服务的情况下优先使用
	- 成员内部类
		- 可以使用访问修饰符修饰
		- 非静态内部类
			- 必须寄存在外部类的对象里；
			```java
			public class Outer {
				public static void main(String[] args) {
					Face face = new Face();
					Face.Nose nose = face.new Nose();
					nose.breath();
				}
			}

			class Face{
				int type;

				class Nose{
					String type;

					void breath() {
						System.out.println(Face.this.type);
					}
				}
			}
			```
			- 非静态内部类不可以定义静态成员，方法以及静态初始化块
		- 静态内部类
			- 静态内部类依托于外部类，内部类存在的时候不一定有外部类的对象存在
			- 静态内部类的实例不可以使用外部类的实例成员和方法(非静态方法)
			- 静态内部类可以使用外部类的静态成员和方法。
			- 外部类的对象无法使用内部类的成员
		- 局部内部类
			- 定义在方法里，几乎不用
	- 匿名内部类
		- 适合那种只需要使用一次的类
			- new 父类构造器(实参列表 实现接口){匿名内部类类体}
- String类中的指向和内容都不可变
- 多维数组
	- JAVA中多维数组不必须是规则矩阵形式
- 数组的拷贝
	- System.arraycopy()
	- 多维数组传递的是引用
	- 打印数组
		- Array.tostring(Arr); -- 只针对一位数组
- 包装类 -- Wrapper class
	- 包装类的作用将基本数据类型转换为类对象
	- 包装类和八种基本数据类型一一对应
		- byte 		-- Byte
		- boolean 	-- Boolean
		- short 	-- Short
		- char 		-- Character
		- int 		-- Integer
		- long 		-- Long
		- float 	-- Float
		- double 	-- Double
- 自动装箱，自动拆箱
	- 装箱
		- Integer a = 1000; 编译器修改为 Integer a = new Integer(1000);
	- 拆箱
		- a = new Integer(100); 编译器修改为 a = (new Integer(100)).intValue();
	- -128~127之间的数在实际中还是当做基本数据类型处理
- 时间类 -- Date
	- 导入 -- import java.util.Date;
- 将时间按照格式化字符串转换成字符串
	```java
		DateFormat df = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss:SSS");
		Date d = new Date(123456456123113L);
		String str = df.format(d);
		System.out.println(str);
	```
- 将字符串转换为时间对象
	``java
		String str01 = "1977-7-7";
		//格式必须和字符串完全一致
		DateFormat df01 = new SimpleDateFormat("yyyy-MM-dd");
		try {
			Date d2 = df01.parse(str01);
			System.out.println(d2);
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
	```
- 将数字和日期相互转换
	- Calendar -- GregorianCalendar
	- 注意
		- 一月是0，二月是1，以此类推，12月是11
		- 周日是1，周一是2...周六是7
- File类
	- 文件或者目录
	- mkdir创建目录的时候，父目录存在的时候只能创建，有且只能创建一个目录
	- mkdirs递归创建目录
- 枚举
	- 枚举的字段时public static final修饰的
- 异常
	- 异常的跟类是Throwable
		- 派生Error
		- 派生Exception
			- RuntimeException -- 运行时异常
			- CheckedException -- 检查型异常
				- try{}catch{}finally{}结构，可以有多个catch。finally可有可无，但finally最多只有一个，多个catch的时候子类在前，父类在后面
				- throws 直接抛出异常
    - 自定义异常
    	- 继承Exception类，编译时必须处理，用try catch处理
    	- 继承RuntimeException，运行时异常，编译时不用try catch处理
- 泛型
	- 泛型的本质就是数据类型的参数化，泛型的类型由编译器处理
	- java中的泛型的标志一般是T Y V
- List接口的常用的实现类有三个：ArrayList，LinkedList和Vector
- 加号的优先级高于以为运算符
- Linkedlist -- 双向链表
	- 查询效率低，增删效率高，线程不安全






















