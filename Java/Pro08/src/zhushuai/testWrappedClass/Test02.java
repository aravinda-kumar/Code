package zhushuai.testWrappedClass;

/**
 * �Զ�װ��Ͳ���
 * @author SHUNCS
 *
 */
public class Test02 {
	public static void main(String[] args) {
		Integer a = new Integer(1000).intValue();
		//jdk 5.0֮��
		//��1000�Զ�װ�������
		Integer b = 1000;
		//��b�Զ������int
		int c = b;
		b.equals(123);
		
	}
}
