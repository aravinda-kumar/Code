public class Stu {
	
	//属性field
	int id;
	String name;
	int age;
	Computer computer;
	//方法
	void Study() {
		System.out.println("Study func " + computer.brand);
	}
	void play() {
		System.out.println("play game func");
	}
	//main方法是程序执行的入口
	public static void main(String[] args) {
		Stu stu = new Stu();
		System.out.println(stu);
		stu.id = 1001;
		stu.name = "zs";
		stu.age = 12;
		
		Computer computer = new Computer();
		computer.brand = "hp";
		stu.computer = computer;
		
		stu.Study();
	}
}

class Computer{
	String brand;
}