
/**
 * exercise
 * @author SHUNCS
 *
 */
public class Execrise {
	public static void main(String[] args) {
		//计算100以内的奇数和
		int sum = 0;
		for(int i=1;i<=100;i++) {
			if(i%2==1) {
				sum += i;
			}
		}
		System.out.println("奇数和="+sum);
		//计算100以内的偶数和
		sum = 0;
		for(int i=1;i<=100;i++) {
			if(i%2==0) {
				sum += i;
			}
		}
		System.out.println("偶数和="+sum);
		
		System.out.println("==========================");
		
		//输出1000以内的能被5整除的数，每行输出5个
		int count = 0;
		for(int i=1;i<=1000;i++) {
			if(i%5==0) {
				count++;
				if(count%5==0) {
					System.out.println(i);
				}
				else {
					System.out.print(i + "\t");
				}
			}
		}
	}
}
