package zhushuai.oop;

/**
 * ≤‚ ‘ºÃ≥–
 * @author SHUNCS
 *
 */
public class TestExtends {
	public static void main(String[] args) {
		Student stu = new Student("zbc", 123, "asd");
		stu.rest();
		stu.study();
		
		System.out.println(stu instanceof Person);
	}
}

class Person{
	public Person() {
		
	}
	String name;
	int height;
	public void rest() {
		System.out.println("have a rest");
	}
}

class Student extends Person{
	String major;
	public Student(String name, int height, String major){
		super();
		this.name = name;
		this.height = height;
		this.major = major;
	}
	public void study(){
		System.out.println("study....");
	}
}