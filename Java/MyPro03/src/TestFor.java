
/**
 * ����forѭ��
 * @author ���
 *
 */
public class TestFor {
	public static void main(String[] args) {
		int  sum = 0;
		
		for(int  i=1; i<=100;i++){
			sum  = sum + i;
		}
	
		System.out.println(sum);
		
		/*
			int   i = 1;
			while(i<=100){
				 sum  =  sum  + i;
				i++;
			}
		*/
		
		/**
		 * 1. ִ�г�ʼ����䣺 i=1;
		 * 2. �ж�i<=100
		 * 3. ִ��ѭ����
		 * 4. ����������i++
		 * 5. �ص��ڶ��������ж�
		 */
		
		 for(int i = 1, j = i + 10; i < 5; i++, j = i * 2) {
	            System.out.println("i= " + i + " j= " + j); 
	     } 
		 
		 for(;;){	//while(true){
			 System.out.println("���㵽��Զ����");
		 }
		 
	}
}
