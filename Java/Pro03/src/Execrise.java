
/**
 * exercise
 * @author SHUNCS
 *
 */
public class Execrise {
	public static void main(String[] args) {
		//����100���ڵ�������
		int sum = 0;
		for(int i=1;i<=100;i++) {
			if(i%2==1) {
				sum += i;
			}
		}
		System.out.println("������="+sum);
		//����100���ڵ�ż����
		sum = 0;
		for(int i=1;i<=100;i++) {
			if(i%2==0) {
				sum += i;
			}
		}
		System.out.println("ż����="+sum);
		
		System.out.println("==========================");
		
		//���1000���ڵ��ܱ�5����������ÿ�����5��
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
