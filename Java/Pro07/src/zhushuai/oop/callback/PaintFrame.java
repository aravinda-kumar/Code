package zhushuai.oop.callback;

import zhushuai.oop.interfaceTest.MyInterface;

public class PaintFrame implements MyInterface{
	public static void drawFrame(MyFrame f) {
		System.out.println("启动线程");
		System.out.println("增加循环");
		System.out.println("查看消息栈");
		
		//绘制窗口
		f.paint();
		
		System.out.println("启动缓存，增加效率");
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