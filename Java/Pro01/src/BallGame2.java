import java.awt.*;
import javax.swing.*;

public class BallGame2 extends JFrame{
	
	Image ball = Toolkit.getDefaultToolkit().getImage("image/ball.png");
	Image desk = Toolkit.getDefaultToolkit().getImage("image/desk.jpg");
	
	double x = 100;	//小球的横坐标
	double y = 100;	//小球的纵坐标
	
	double degree = 3.14/3; //弧度，此处就是：60度
	
	//绘制窗口的办法
	public void paint(Graphics g)
	{
		System.out.println("斜角运动窗口被绘制一次");
		//先绘制桌面再绘制球
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
	
	//窗口加载
	void launchFrame() {
		setSize(856, 500);
		setLocation(50, 50);
		setVisible(true);
		
		//重画窗口,每秒重画25次
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
	
	//main方法是程序执行的入口
	public static void main(String[] args) {
		System.out.println("Hello World! Game2");
		BallGame2 game = new BallGame2();
		game.launchFrame();
	}
}
