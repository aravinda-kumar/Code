/**
 * ����ifelseifelse��ѡ��ṹ
 * 
 * @author ���
 *
 */
public class TestIfElseIfElse {
	public static void main(String[] args) {
		int age = (int) (100 * Math.random());
		System.out.print("������" + age + "�� ����");
		if (age < 15) {
			System.out.println("��ͯ�� ϲ���棡");
		} else if (age < 25) {
			System.out.println("���꣬ Ҫѧϰ��");
		} else if (age < 45) {
			System.out.println("���꣬ Ҫ������");
		} else if (age < 65) {
			System.out.println("�����꣬ Ҫ���ƣ�");
		} else if (age < 85) {
			System.out.println("���꣬ ���˶���");
		} else {
			System.out.println("�����ǣ� ����ϡ��");
		}
	}
}