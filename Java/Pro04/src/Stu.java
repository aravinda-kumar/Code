public class Stu {
	
	//����field
	int id;
	String name;
	int age;
	Computer computer;
	//����
	void Study() {
		System.out.println("Study func " + computer.brand);
	}
	void play() {
		System.out.println("play game func");
	}
	//main�����ǳ���ִ�е����
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