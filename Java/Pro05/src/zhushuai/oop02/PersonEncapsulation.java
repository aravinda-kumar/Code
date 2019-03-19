package zhushuai.oop02;

/**
 * ²âÊÔ·â×°
 * @author SHUNCS
 *
 */
public class PersonEncapsulation {
	private int id;
	private String name;
	private int age;
	private boolean man;
	
	//getter setter
	public void setName(String name) {
		this.name = name;
	}
	
	public void setAge(int age) {
		if(age >=1 && age <= 130) {
			this.age = age;
		}
		else {
			System.out.println("ÄêÁä´íÎó");
		}
	}
	public String getName() {
		return this.name;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public boolean isMan() {
		return man;
	}

	public void setMan(boolean man) {
		this.man = man;
	}

	public int getAge() {
		return age;
	}
	
	
}
