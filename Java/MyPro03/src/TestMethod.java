
/**
 * ���Է����Ļ���ʹ��
 * @author ���
 *
 */
public class TestMethod {
	public static void main(String[] args) {
		//ͨ�����������ͨ����
		TestMethod   tm  = new TestMethod();
		tm.printSxt();
		int c = tm.add(30, 40, 50)+1000;
		System.out.println(c); 
	}
	
	void  printSxt(){
		System.out.println("������ѧ��...");
		System.out.println("�Ϻ���ѧ��...");
		System.out.println("������ѧ��...");
	}
	
	int  add(int a, int b, int c){
		int  sum =  a+b+c;
		System.out.println(sum);
		return  sum;			//return �������ã�1.�������������С�2.����ֵ
	}
	
}
