package zhushuai.StringClass;

public class TestString {
	public static void main(String[] args) {
		String str = "abcd";
		str.replace('b', '*');
		System.out.println(str);
		
		String str2 = "aaa,ddd,ccc,eee";
		String[] strsStrings = str2.split(",");
		for(int i=0;i<strsStrings.length; i++) {
			System.out.println(strsStrings[i]);
		}
		
		System.out.println("ABC".equalsIgnoreCase("abc"));
		System.out.println("abbcc".lastIndexOf('c'));
		
//		final int[] a = {1,2,3};
//		a[0] = 12;
//		int[] b = {4,5,6};
//		a = b;
		char[] ch = {'a', 'b', 'c'};
	}
}