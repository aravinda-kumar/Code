package zhuhsuai.johnson;

public class TestEncapsulation01 {
	public static void main(String[] args) {
		Human h = new Human();
		//h.age = 13;
		h.height = 123;
	}
}

class Boy extends Human{
	void sayHello() {
		//System.out.println(age);
	}
}