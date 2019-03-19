package zhushuai.oop02;

/**
 * ²âÊÔ¶àÌ¬
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
		System.out.println("½ĞÁËÒ»Éù");
	}
}

class Dog extends Animal{
	public void shout() {
		System.out.println("ÍúÍú");
	}
}

class Cat extends Animal{
	public void shout() {
		System.out.println("ß÷ß÷");
	}
}