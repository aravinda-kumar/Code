package zhushuai.oop.abstractclass;

public abstract class Animal {
	public abstract void run();
	public void breath() {
		System.out.println("Animal breath");
	}
}

class Cat extends Animal{
	@Override
	public void run() { 
		// TODO Auto-generated method stub
		System.out.println("cat run");
	}
}

class Dog extends Animal{
	@Override
	public void run() {
		// TODO Auto-generated method stub
		System.out.println("dog run");
	}
}