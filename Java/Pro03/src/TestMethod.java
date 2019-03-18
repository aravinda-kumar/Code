/**
 * 测试方法的基本使用
 * @author SHUNCS
 *
 */
public class TestMethod {
	public static void main(String[] args) {
		//通过对象调用普通方法
		TestMethod tm = new TestMethod();
		printInfo();
		tm.add(1, 2, 3);
		tigui();
		long d1 = System.currentTimeMillis();
		System.out.println(d1);
		System.out.println(fac(10));
		try {
			Thread.sleep(1000);
		} catch (Exception e) {
			// TODO: handle exception
		}
		
		long d2 = System.currentTimeMillis();
		System.out.println(d2-d1);
		d2 = System.currentTimeMillis();
		System.out.println(d2);
		
	}
	
	static void printInfo() {
		System.out.println("infomation......");
	}
	
	void add(int a, int b, int c) {
		System.out.println(a+b+c);
	}
	static int count =0;
	static void tigui(){
		System.out.println(count++);
		if(count == 1000) {
			return;
		}
		tigui();
	}
	
	static long fac(long n) {
		if(n == 1) {
			return 1;
		}
		else {
			return n*fac(n-1);
		}
	}
}
