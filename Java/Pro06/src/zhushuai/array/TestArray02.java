package zhushuai.array;

public class TestArray02 {
	public static void main(String[] args) {
		//静态初始化
		int[] a = {1,2,3,4,5};					//数组静态初始化
		User[] b = {new User(), new User()};	//对象静态初始化
		
		//默认初始化
		int[] d = new int[3];	//赋值的规则和成员变量默认赋值的规则一样
		
		//动态初始化，利用下标挨个赋值
		d[0] = 1;
	}
}
