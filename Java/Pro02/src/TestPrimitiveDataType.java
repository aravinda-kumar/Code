import java.math.*;
/**
 * ���Ի�����������
 * @author SHUNCS
 *
 */
public class TestPrimitiveDataType {
	public static void main(String[] args) {
		int a = 15;			//ʮ����
		int b = 015;		//�˽���
		int c = 0x15;		//ʮ������
		int d = 0b11111;	//������
		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
		System.out.println(d);
		
		//��ֵ����Խ��
		//byte age = 300;
		//���γ���Ĭ����int����
		long globalPopulation = 7400000000L;	//�����l����L��ʾ�ǳ����γ���
		
		//BigDecimal����
		//BigDecimal��һ���࣬Ҫע�ص�����ķ���
		BigDecimal bd = BigDecimal.valueOf(1.0);
		bd = bd.subtract(BigDecimal.valueOf(0.1));
		if(bd.equals(BigDecimal.valueOf(0.9))){
			System.out.println("bd == 0.9");
		}
		else {
			System.out.println("bd != 0.9");
		}
			
	}
}
