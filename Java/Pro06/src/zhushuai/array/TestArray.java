package zhushuai.array;

public class TestArray {
	public static void main(String[] args) {
		int[] arr01 = new int[10];
		String[] arr02 = new String[5];
		User[] arr03 = new User[3];
		
		
		
		
		//给数组赋值
		for(int i=0;i<10;i++) {
			arr01[i] = i;
		}
		
		//给对象初始化
		for(int i=0;i<3;i++) {
			arr03[i] = new User();
		}

	}
}