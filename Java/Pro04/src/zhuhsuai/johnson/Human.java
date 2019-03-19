package zhuhsuai.johnson;

public class Human {
	private int age;
	String name;	//可以被本包中的类访问
	protected int height;
	
	void sayAge(){
		System.out.println(age);
	}
}
