package zhushuai.stringbuilder;

/**
 * 测试StringBuilder(可变字符序列) -- 线程不安全，效率高
 * StringBuffer -- 线程安全，效率低
 * @author SHUNCS
 *
 */
public class Test01 {
	public static void main(String[] args) {
		StringBuilder sb = new StringBuilder();			//字符个数为16的字符串
		StringBuilder sb1 = new StringBuilder(32);		//字符个数为32的字符串	
		StringBuilder sb2 = new StringBuilder("abcd");	//创建16+4的字符串
		sb2.append(true);
		System.out.println(sb2);
	}
}
