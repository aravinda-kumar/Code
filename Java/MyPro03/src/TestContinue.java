
/**
 * 测试continue continue用于结束本次循环，继续循环下一次
 * 
 * @author 高淇
 *
 */
public class TestContinue {
	public static void main(String[] args) {
		
//		把100~150之间不能被3整除的数输出，并且每行输出5个
		
		int count = 0;// 定义计数器
		for (int i = 100; i < 150; i++) {
			// 如果是3的倍数，则跳过本次循环，继续进行下一次循环
			if (i % 3 == 0) {
				continue;
			}
			// 否则（不是3的倍数），输出该数
			System.out.print(i + "、");
			count++;// 没输出一个数，计数器加1
			// 根据计数器判断每行是否已经输出了5个数
			if (count % 5 == 0) {
				System.out.println();
				count = 0;
			}
		}
	}
}
