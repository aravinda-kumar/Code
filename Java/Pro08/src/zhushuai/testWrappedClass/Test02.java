package zhushuai.testWrappedClass;

/**
 * 自动装箱和拆箱
 * @author SHUNCS
 *
 */
public class Test02 {
	public static void main(String[] args) {
		Integer a = new Integer(1000).intValue();
		//jdk 5.0之后
		//将1000自动装箱成类型
		Integer b = 1000;
		//将b自动拆箱成int
		int c = b;
		b.equals(123);
		
	}
}
