import java.math.*;
/**
 * 测试基本数据类型
 * @author SHUNCS
 *
 */
public class TestPrimitiveDataType {
	public static void main(String[] args) {
		int a = 15;			//十进制
		int b = 015;		//八进制
		int c = 0x15;		//十六进制
		int d = 0b11111;	//二进制
		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
		System.out.println(d);
		
		//数值类型越界
		//byte age = 300;
		//整形常量默认是int类型
		long globalPopulation = 7400000000L;	//后面加l或者L表示是长整形常量
		
		//BigDecimal测试
		//BigDecimal是一个类，要注重调用类的方法
		BigDecimal bd = BigDecimal.valueOf(1.0);
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		if(bd.equals(BigDecimal.valueOf(0.9))){
			System.out.println("bd == 0.9");
		}
		else {
			System.out.println("bd != 0.9");
		}
			
	}
}
