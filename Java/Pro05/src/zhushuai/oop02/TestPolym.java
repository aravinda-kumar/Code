package zhushuai.oop02;

/**
 * ���Զ�̬
 * @author SHUNCS
 *
 */
public class TestPolym {
	public static void main(String[] args) {
		Animal animal = new Dog();
		animalCry(animal);
	}
	
	static void animalCry(Animal animal) {
		animal.shout();
	}
}

class Animal{
	public void shout() {
		System.out.println("����һ��");
	}
}

class Dog extends Animal{
	public void shout() {
		System.out.println("����");
	}
}

class Cat extends Animal{
	public void shout() {
		System.out.println("����");
	}
}