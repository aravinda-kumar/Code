import java.awt.*;
import javax.swing.*;

public class BallGame extends JFrame{
	
	Image ball = Toolkit.getDefaultToolkit().getImage("image/ball.png");
	Image desk = Toolkit.getDefaultToolkit().getImage("image/desk.jpg");
	
	double x = 100;	//С��ĺ�����
	double y = 100;	//С���������
	
	boolean right = true; //����
	
	//���ƴ��ڵİ취
	public void paint(Graphics g)
	{
		System.out.println("���ڱ�����һ��");
		g.drawImage(desk, 0, 0, null);
		g.drawImage(ball, (int)x, (int)y, null);
		
		if(right) {
			x = x + 10;
		}
		else {
			x = x - 10;
		}
		
		//30��С���ֱ����40�����ӱ߿�Ĵ�С
		if(x>850-40-30) {
			right = false;
		}
		if(x<40)
		{
			right = true;
		}
	}
	
	//���ڼ���
	void launchFrame() {
		setSize(856, 500);
		setLocation(50, 50);
		setVisible(true);
		
		//�ػ�����,ÿ���ػ�25��
		while(true) {
			repaint();
			try	{
				Thread.sleep(40);  //40ms
			}
			catch(Exception e) {
				e.printStackTrace();
			}
			
		}
	}
	
	//main�����ǳ���ִ�е����
	public static void main(String[] args) {
		System.out.println("Hello World!");
		BallGame game = new BallGame();
		game.launchFrame();
	}
}
