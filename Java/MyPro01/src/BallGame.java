
import  java.awt.*;
import javax.swing.*;

public class BallGame extends JFrame {
	
	Image ball = Toolkit.getDefaultToolkit().getImage("images/ball.png");
	Image desk = Toolkit.getDefaultToolkit().getImage("images/desk.jpg");
	
	double  x=100;	//小球的横坐标
	double  y=100; //小球的纵坐标
	//画窗口的方法
	public void paint(Graphics  g){
		System.out.println("窗口被画了一次！");
		g.drawImage(desk, 0, 0, null);
		g.drawImage(ball, (int)x, (int)y, null);
	}
	
	//窗口加载
	void launchFrame(){
		setSize(856,500);
		setLocation(50,50);
		setVisible(true);
	}
	
	//main方法是程序执行的入口
	public static void main(String[] args){
		System.out.println(" 我是尚学堂高淇，这个游戏项目让大家体验编程的快感，寓教于乐！");
		BallGame game = new BallGame();
		game.launchFrame();
	}
	
}
