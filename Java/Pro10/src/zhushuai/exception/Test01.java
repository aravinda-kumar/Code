package zhushuai.exception;

/**
 * runtime exception����ʱ�쳣�Ļ�������
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
		
		//��ָ���쳣
		String str = new String("123");
		if(str != null) {
			System.out.println(str.length());		
		}
		
		//����ת���쳣
		if(str instanceof String) {
			System.out.println("it is a string");
		}
		
		//Խ����쳣����
		int index = 2;
		if(index < str.length()) {
			System.out.println(str.charAt(index));
		}
		
	}
}
