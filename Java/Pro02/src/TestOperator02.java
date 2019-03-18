/**
 * ²âÊÔ¶ÌÂ·
 * @author SHUNCS
 *
 */
public class TestOperator02 {
	public static void main(String[] args) {
		boolean b1 = true;
		boolean b2 = false;
		
		System.out.println(b1^b2);
		
		System.out.println(b1 && b2);
		//¶ÌÂ·²âÊÔ
		int a = 12;
		boolean b3 = b2 & (++a)==13;
		System.out.println(a);
		b3 = b2 & (++a)==14;
		System.out.println(a);
		boolean b4 = 1>2&&(3/0)>2;
		System.out.println(b4);
	}
}
