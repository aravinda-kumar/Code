package zhushuai.oop;

/**
 * ≤‚ ‘÷ÿ–¥
 * @author SHUNCS
 *
 */
public class TestOverride {
	public static void main(String[] args) {
		Horse horse = new Horse();
		horse.run();
		horse.stop();
	}
}

class Vehicle{
	public void run() {
		System.out.println("Run...");
	}
	
	public void stop() {
		System.out.println("Stop...");
	}
}

class Horse extends Vehicle{
	@Override
	public void run() {
		super.run();
		System.out.println("deng deng deng...");
	}

}