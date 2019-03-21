package zhushuai.exception;

/**
 * runtime exception运行时异常的基本处理
 * @author 11094
 *
 */
public class Test01 {
	public static void main(String[] args) {
		int a = 0;
		try {
			a = 1/0;
						
		} catch (Exception e) {
			// TODO: handle exception
			//e.printStackTrace();
			System.out.println(e.toString());
		}
		System.out.println(a);
		
		//空指针异常
		String str = new String("123");
		if(str != null) {
			System.out.println(str.length());		
		}
		
		//类型转换异常
		if(str instanceof String) {
			System.out.println("it is a string");
		}
		
		//越界的异常处理
		int index = 2;
		if(index < str.length()) {
			System.out.println(str.charAt(index));
		}
		
	}
}
