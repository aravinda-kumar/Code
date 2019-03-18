package zhushuai.oop;

/**
 * ≤‚ ‘object
 * @author SHUNCS
 *
 */
public class TestObject {
	public static void main(String[] args) {
		TestObject ob = new TestObject();
		System.out.println(ob.toString());
		
		PersonNew p = new PersonNew();
		p.name = "123";
		p.age = 45;
		System.out.println(p.toString());
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		
		return "TestObject";
	}
}

class PersonNew{
	String name;
	int age;
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return name + " " + age;
	}
}