package zhushuai.oop.interfaceTest;

public class MyClass implements MyInterface{

	@Override
	public void test01() {
		// TODO Auto-generated method stub
		String bossString = MyInterface.MAX_GREAD;
		System.out.println("test01 in myclass");
	}

	@Override
	public int test01(int a, int b) {
		// TODO Auto-generated method stub
		return 0;
	}
	
}
