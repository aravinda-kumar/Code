
/**
 * ����if��ѡ��ṹ
 * @author ���
 *
 */
public class TestIf {
	public static void main(String[] args) {
		double  d = Math.random();    //���ء�0��1)֮��������
		System.out.println(d);
		
		int  h= (int)(6*Math.random()+1);
		System.out.println(h);
		if(h<=3) {
			 System.out.println("С");
			 System.out.println("ССС");
		}
		
		System.out.println("########################");
		//ͨ�����������ӿ��������������Σ�
        int i = (int)(6 * Math.random()) + 1;//ͨ��Math.random()���������
        int j = (int)(6 * Math.random()) + 1;
        int k = (int)(6 * Math.random()) + 1;
        int count = i + j + k;
        //�����������֮�ʹ���15������������
        if(count > 15) {
            System.out.println("������������");
        }
        //�����������֮����10��15֮�䣬������һ��
        if(count >= 10 && count <= 15) { //����д����10<=count<=15
            System.out.println("����������һ��");
        }
        //�����������֮��С��10������������ô��
        if(count < 10) {
            System.out.println("������������ô��");
        }
        System.out.println("����" + count + "��");
		
		
	}
}
