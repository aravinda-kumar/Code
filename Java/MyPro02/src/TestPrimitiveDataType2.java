import java.math.*;
/**
 * 测试浮点型
 * 
 * @author Administrator
 *
 */
public class TestPrimitiveDataType2 {

	public static void main(String[] args) {
		float a = 3.14F;
		double b = 6.28;
		double c = 628E-2;

		System.out.println(c);

		// 浮点数是不精确的，一定不要用于比较！
		float f = 0.1f;
		double d = 1.0 / 10;
		System.out.println(f == d); // 结果为false

		float d1 = 423432423f;
		float d2 = d1 + 1;
		if (d1 == d2) {
			System.out.println("d1==d2");// 输出结果为d1==d2
		} else {
			System.out.println("d1!=d2");
		}

		System.out.println("##################");	
		//使用精确浮点运行，推荐：BigDecimal
		BigDecimal bd = BigDecimal.valueOf(1.0);
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		System.out.println(bd);// 0.5
		System.out.println(1.0 - 0.1 - 0.1 - 0.1 - 0.1 - 0.1);// 0.5000000000000001
		
		BigDecimal  bd2 = BigDecimal.valueOf(0.1);
		BigDecimal  bd3 = BigDecimal.valueOf(1.0/10.0);
		
		System.out.println(bd2.equals(bd3)); 

	}
}
