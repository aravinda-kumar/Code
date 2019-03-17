/**
 * 测试运算符
 * @author SHUNCS
 *
 */
public class TestOperator01 {
	public static void main(String[] args) {
		byte a = 1;
		int b = 2;
		//整数运算，没有long，结果就是int
		byte c = (byte)(a + b);
		long d = 12;
		int c2 = (int)(d + b);		//不进行类型转换,报错
		float f1 = 1;
		double d2 = 2;
		float f2 = (float)(f1 + d2);
		
		int m = 3;
		int n = 4;
		m *= n + 3; //等价于m = m * (n + 3)
		System.out.println(m);
	}
}
