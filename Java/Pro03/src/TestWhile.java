
/**
   * 测试while循环
 * @author SHUNCS
 *
 */
public class TestWhile {
	public static void main(String[] args) {
		//计算100以内的数的累加和
		int i=0;
		int sum = 0;
		while(i<=100){
			sum += i;
			i++;
		}
		System.out.println(sum);
	}
}
