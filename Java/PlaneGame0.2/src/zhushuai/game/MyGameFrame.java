package zhushuai.game;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
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
	Image plane = GameUtil.getImage("images/plane.png");
	
	//飞机坐标
	int planeX = 250;
	int planeY = 250;
	
	//自动调用
	//变量g相当于一直画笔
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		
		//在给定位置绘制出背景和前景图片
		g.drawImage(bg, 0, 0, null);
		g.drawImage(plane, planeX, planeY, null);
		planeX++;
		planeY++;
	}
	
	//帮助我们反复的重画窗口
	class PaintThread extends Thread{
		//内部类可以直接使用外部类的属性
		@Override
		public void run() {
			while(true) {
				System.out.println("+++++++++++");
				repaint();	//重画窗口
				
				try {
					Thread.sleep(40);
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
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
	}
	
	
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
}
