
/**
   *    ����switch�ṹ
 * @author SHUNCS
 *
 */
public class TestSwitch {
	public static void main(String[] args) {
		int month = (int)(1 + Math.random()*12);
		System.out.println("�·�:"+month);
		switch (month) {
		case 1:
			System.out.println("һ�·�");
			break;
		case 2:
			System.out.println("���·�");
		default:
			System.out.println("�����·�");
			break;
		}
		System.out.println("#####################");
		//Ԫ���ж�
		char ch = 'a';
		ch = (char)(ch + (int)(26*Math.random()));
		System.out.println("ch = "+ ch);
		switch(ch) {
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			System.out.println("Ԫ����ĸ");
			break;
		case 'y':
		case 'w':
			System.out.println("��Ԫ��");
			break;
		default:
			System.out.println("����");
		}
	}
}
