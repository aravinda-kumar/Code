
/**
 * ���Եݹ�
 * 
 * @author ���
 *
 */
public class TestRecursion {

	public static void main(String[] args) {
		long d1 = System.currentTimeMillis();
		System.out.printf("%d�׳˵Ľ��:%s%n", 10, factorial(10));
		long d2 = System.currentTimeMillis();
		System.out.printf("�ݹ��ʱ��%s%n", d2 - d1); // ��ʱ��32ms
		
		factorialLoop(10); 
	}

	/** ��׳˵ķ��� */
	static long factorial(int n) {
		if (n == 1) {// �ݹ�ͷ
			return 1;
		} else {// �ݹ���
			return n * factorial(n - 1);// n! = n * (n-1)!
		}
		//1*2*3*4*5...*10
	}
	
	static  long  factorialLoop(int a){
		long d3 = System.currentTimeMillis();
        long  result = 1;
        while (a > 1) {
            result *= a * (a - 1);
            a -= 2;
        }
        long d4 = System.currentTimeMillis();
        System.out.println(result);
        System.out.printf("��ͨѭ����ʱ��%s%n", d4 - d3);
        return  result;
	}

}
