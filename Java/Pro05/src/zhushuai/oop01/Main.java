package zhushuai.oop01;

public class Main {
	public static void main(String[] args) {
		Base b = new Base("jzs", 23, 123, 'm');
		System.out.println(b);
		b.age = 12;
		b.height = 234;
		b.sex = 'm';
	}
}
