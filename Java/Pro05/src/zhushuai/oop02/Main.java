package zhushuai.oop02;

import zhushuai.oop01.Base;;
public class Main {
	public static void main(String[] args) {
		Base base = new Base("zs", 123, 456, 'm');
		
		base.sex = 'f';
		
		System.out.println(base);
		
		De de = new De("jzs", 23, 123, 'm');
		de.changeHeight(12);
		System.out.println(de);
		
//		PersonEncapsulation p = new PersonEncapsulation();
//		p.setAge(-14);
//		System.out.println(p.getAge());
	}
}

class De extends Base{
	public De(String name, int age, int height, char sex) {
		super(name, age, height, sex);
	}
	void changeHeight(int m) {
		height += m;
	}
}