package zhushuai.oop01;

public class Base {
	
	public Base(String name, int age, int height, char sex) {
		// TODO Auto-generated constructor stub
		this.name = name;
		this.age = age;
		this.height = height;
		this.sex = sex;
	}
	
	private String name;	//类中可见，其他位置不可见
	int age;				//类中可见，本包中可见
	protected int height;	//类中可见，其他包中子类可见
	public char sex;		//左右位置都可见
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return name + " " + age + " " + height  + " " + sex;
	}
	
}
