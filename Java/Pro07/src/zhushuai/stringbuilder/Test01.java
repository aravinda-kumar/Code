package zhushuai.stringbuilder;

/**
 * ����StringBuilder(�ɱ��ַ�����) -- �̲߳���ȫ��Ч�ʸ�
 * StringBuffer -- �̰߳�ȫ��Ч�ʵ�
 * @author SHUNCS
 *
 */
public class Test01 {
	public static void main(String[] args) {
		StringBuilder sb = new StringBuilder();			//�ַ�����Ϊ16���ַ���
		StringBuilder sb1 = new StringBuilder(32);		//�ַ�����Ϊ32���ַ���	
		StringBuilder sb2 = new StringBuilder("abcd");	//����16+4���ַ���
		sb2.append(true);
		System.out.println(sb2);
	}
}
