package zhushuai.oop.callback;

import zhushuai.oop.interfaceTest.MyInterface;

public class PaintFrame implements MyInterface{
	public static void drawFrame(MyFrame f) {
		System.out.println("�����߳�");
		System.out.println("����ѭ��");
		System.out.println("�鿴��Ϣջ");
		
		//���ƴ���
		f.paint();
		
		System.out.println("�������棬����Ч��");
	}
	public static void main(String[] args) {
		drawFrame(new GameFrame01());
	}
	@Override
	public void test01() {
		// TODO Auto-generated method stub
		
	}
	@Override
	public int test01(int a, int b) {
		// TODO Auto-generated method stub
		return 0;
	}
}

class GameFrame01 extends MyFrame{
	@Override
	public void paint() {
		System.out.println("GameFrame01.paint()");
	}
}