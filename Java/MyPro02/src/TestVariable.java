
/**
 * 测试变量
 * 
 * @author 高淇
 *
 */
public class TestVariable {

	int a;			//成员变量, 从属于对象； 成员变量会自动被初始化
	static  int  size;   //静态变量，从属于类
	
	public static void main(String[] args) {

		{
			int age;		//局部变量，从属于语句块；
			age = 18;
		}
		
		int salary = 3000;	//局部变量，从属于方法

		int gao = 13;
		System.out.println(gao);

		int i;
	//	int j = i + 5; // 编译出错，变量i还未被初始化
		
		
	}
}
