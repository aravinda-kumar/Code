
/**
 * ����ѭ������е�break
 * 
 * @author ���
 *
 */
public class TestBreak {
	public static void main(String[] args) {
		int total = 0;// ���������
		System.out.println("Begin");
		while (true) {
			total++;// ÿѭ��һ�μ�������1
			int i = (int) Math.round(100 * Math.random());
			System.out.println(i);
			// ��i����88ʱ���˳�ѭ��
			if (i == 88) {
				break;
			}
		}
		// ���ѭ���Ĵ���
		System.out.println("Game over�� used " + total + " times.");
	}

}
