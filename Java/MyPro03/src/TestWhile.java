/**
 * 测试while循环
 * @author 高淇
 *
 */
public class TestWhile {
	public static void main(String[] args) {
		//计算1+2+3+4...+100的累加的和，5050.
		//暴力！
		int  sum = 0;
		
		int   i = 1;
		while(i<=100){
			 sum  =  sum  + i;
			i++;
		}
		
		/**
		 * 1. 执行初始化语句： i=1;
		 * 2. 判断i<=100
		 * 3. 执行循环体
		 * 4. 步进迭代：i++
		 * 5. 回到第二步继续判断
		 */
		
		System.out.println(sum);
		
	}
}
