# JAVA内部类
- 在Java中，可以将一个类定义在另一个类里面或者一个方法里面，这样的类称为内部类
- 广泛意义上的内部类一般来说包括四种：
	- 成员内部类
	- 局部内部类
	- 匿名内部类
	- 静态内部类。
- 成员内部类
	- 成员内部类是最普通的内部类，它的定义为位于另一个类的内部，形如下面的形式：
	```java
	class Circle {
		private double radius = 0;
		public static int count =1;
		public Circle(double radius) {
			this.radius = radius;
		}

		class Draw {     //内部类
			public void drawSahpe() {
				System.out.println(radius);  //外部类的private成员
				System.out.println(count);   //外部类的静态成员
			}
		}
	}
	```
	- 非静态内部类依托于外部类的对象存在，所以可以无条件的使用外部内的所有成员，无论是否是private
	- 过要注意的是，当成员内部类拥有和外部类同名的成员变量或者方法时，会发生隐藏现象，即默认情况下访问的是成员内部类的成员
	- 如果要访问外部类的同名成员，需要以下面的形式进行访问：
		- 外部类.this.成员变量
		- 外部类.this.成员方法
	- 外部类中如果要访问成员内部类的成员，必须先创建一个成员内部类的对象，再通过指向这个对象的引用来访问
	```java
		public void showDraw() {
			Draw draw = new Draw();
			draw.drawSahpe();
			//必须通过内部类的实例调用
			//error drawSahpe();
		}
	```
- 局部内部类
	- 局部内部类是定义在一个方法或者一个作用域里面的类，它和成员内部类的区别在于局部内部类的访问仅限于方法内或者该作用域内。
- 匿名内部类
	- 匿名内部类应该是平时我们编写代码时用得最多的，在编写事件监听的代码时使用匿名内部类不但方便，而且使代码更加容易维护。下面这段代码是一段Android事件监听代码：
	```java
	scan_bt.setOnClickListener(new OnClickListener() {
		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
		}
	});

	history_bt.setOnClickListener(new OnClickListener() {
		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
		}
	});
	```
	- 这段代码为两个按钮设置监听器，这里面就使用了匿名内部类。
	```java
	interface inner{
		void display();
	}

	class Anno{
		public void disclose() {
			new inner() {
				@Override
				public void display() {
					System.out.println("This is a anno");

				}
			}.display();
		}
	}
	```
- 静态内部类
	- 静态内部类不需要依赖于外部类
	- 不能使用外部类的非static成员变量或者方法

- main函数中创建内部类都得使用以下格式
	- 创建静态内部类对象的一般形式为：外部类类名.内部类类名 xxx = new 外部类类名.内部类类名()
	- 创建成员内部类对象的一般形式为：外部类类名.内部类类名 xxx = 外部类对象名.new 内部类类名()