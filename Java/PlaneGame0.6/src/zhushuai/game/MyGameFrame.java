package zhushuai.game;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.swing.JFrame;

/**
 * 飞机游戏的主窗口
 * @author SHUNCS
 *
 */
public class MyGameFrame extends JFrame{
	
	//常见背景和飞机对象
	Image bg = GameUtil.getImage("images/bg.jpg");
	Image planeImg = GameUtil.getImage("images/plane.png");
	
	Plane plane = new Plane(planeImg, 250, 250);
	
	//自动调用
	//变量g相当于一直画笔
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		
		//在给定位置绘制出背景和前景图片
		g.drawImage(bg, 0, 0, null);
		
		//绘制飞机
		plane.drawSelf(g);
	}
	
	//帮助我们反复的重画窗口
	class PaintThread extends Thread{
		//内部类可以直接使用外部类的属性
		@Override
		public void run() {
			while(true) {
				//System.out.println("+++++++++++");
				repaint();	//重画窗口
				
				try {
					Thread.sleep(40);
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		}
	}
	
	//键盘监听
	class KeyMonitor extends KeyAdapter{

		//键盘按下
		@Override
		public void keyPressed(KeyEvent e) {
			plane.addDirection(e);
		}

		//按键释放
		@Override
		public void keyReleased(KeyEvent e) {
			plane.minusDirection(e);
		}
		
	}
	
	//初始化窗口
	public void launchFrame() {
		//设置窗口标题
		this.setTitle("Game");
		//显示窗口
		this.setVisible(true);
		//设置窗口的大小
		this.setSize(500, 500);
		//设置窗口的默认位置
		this.setLocation(300, 300);
		
		//关闭窗口
		this.addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});
		
		new PaintThread().start();
		addKeyListener(new KeyMonitor()); //给键盘添加监听
		System.out.println("程序结尾");
	}
	
	
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
}
