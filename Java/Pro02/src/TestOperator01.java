/**
 * ���������
 * @author SHUNCS
 *
 */
public class TestOperator01 {
	public static void main(String[] args) {
		byte a = 1;
		int b = 2;
		//�������㣬û��long���������int
		byte c = (byte)(a + b);
		long d = 12;
		int c2 = (int)(d + b);		//����������ת��,����
		float f1 = 1;
		double d2 = 2;
		float f2 = (float)(f1 + d2);
		
		int m = 3;
		int n = 4;
		m *= n + 3; //�ȼ���m = m * (n + 3)
		System.out.println(m);
	}
}
