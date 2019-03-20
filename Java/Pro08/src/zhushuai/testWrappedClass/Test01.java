package zhushuai.testWrappedClass;

public class Test01 {
	public static void main(String[] args) {
		Integer i = new Integer(1000);
		i = i + 12;
		System.out.println(i);
		System.out.println(i.intValue());
	}
}
