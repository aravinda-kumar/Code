/**
 * ����whileѭ��
 * @author ���
 *
 */
public class TestWhile {
	public static void main(String[] args) {
		//����1+2+3+4...+100���ۼӵĺͣ�5050.
		//������
		int  sum = 0;
		
		int   i = 1;
		while(i<=100){
			 sum  =  sum  + i;
			i++;
		}
		
		/**
		 * 1. ִ�г�ʼ����䣺 i=1;
		 * 2. �ж�i<=100
		 * 3. ִ��ѭ����
		 * 4. ����������i++
		 * 5. �ص��ڶ��������ж�
		 */
		
		System.out.println(sum);
		
	}
}
