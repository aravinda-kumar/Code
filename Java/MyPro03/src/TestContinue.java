
/**
 * ����continue continue���ڽ�������ѭ��������ѭ����һ��
 * 
 * @author ���
 *
 */
public class TestContinue {
	public static void main(String[] args) {
		
//		��100~150֮�䲻�ܱ�3�����������������ÿ�����5��
		
		int count = 0;// ���������
		for (int i = 100; i < 150; i++) {
			// �����3�ı���������������ѭ��������������һ��ѭ��
			if (i % 3 == 0) {
				continue;
			}
			// ���򣨲���3�ı��������������
			System.out.print(i + "��");
			count++;// û���һ��������������1
			// ���ݼ������ж�ÿ���Ƿ��Ѿ������5����
			if (count % 5 == 0) {
				System.out.println();
				count = 0;
			}
		}
	}
}
