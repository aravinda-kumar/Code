import java.awt.*;
import javax.swing.*;

public class BallGame2 extends JFrame{
	
	Image ball = Toolkit.getDefaultToolkit().getImage("image/ball.png");
	Image desk = Toolkit.getDefaultToolkit().getImage("image/desk.jpg");
	
	double x = 100;	//С��ĺ�����
	double y = 100;	//С���������
	
	double degree = 3.14/3; //���ȣ��˴����ǣ�60��
	
	//���ƴ��ڵİ취
	public void paint(Graphics g)
	{
		System.out.println("б���˶����ڱ�����һ��");
		//�Ȼ��������ٻ�����
		g.drawImage(desk, 0, 0, null);
		g.drawImage(ball, (int)x, (int)y, null);
		
		x = x + 10 * Math.cos(degree);
		y = y + 10 * Math.sin(degree);
		
		if(y > 500-40-30 || y < 40+30) {
			degree = -degree;
		}
		if(x>850-40-30 || x<40)
		{
			degree = 3.14-degree;
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
		System.out.println("Hello World! Game2");
		BallGame2 game = new BallGame2();
		game.launchFrame();
	}
}
