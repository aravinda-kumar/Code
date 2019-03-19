package zhushuai.game;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.Date;

import javax.swing.JFrame;
import javax.swing.text.StyledEditorKit.ForegroundAction;

/**
 * 飞机游戏的主窗口
 * @author SHUNCS
 *
 */
public class MyGameFrame extends JFrame{
	
	//常见背景和飞机对象
	Image bg = GameUtil.getImage("images/bg.jpg");
	Image planeImg = GameUtil.getImage("images/plane.png");
	
	//显示飞机
	Plane plane = new Plane(planeImg, 400, 400);
	
	//其实时间和结束时间
	Date startTime = new Date();
	Date endTime;
	//游戏持续的时间
	int period;
	
	//产生一个炮弹
	//Shell shell = new Shell();
	
	Shell[] shells = new Shell[50];
	
	//爆炸对象
	Explode bao;
	
	//自动调用
	//变量g相当于一直画笔
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		
		//在给定位置绘制出背景和前景图片
		g.drawImage(bg, 0, 0, null);
		
		//绘制飞机
		plane.drawSelf(g);
		
		//绘制炮弹
		//shell.draw(g);
		
		//绘制一堆炮弹
		for(int i=0;i<shells.length;i++) {
			shells[i].draw(g);
			
			boolean touch = shells[i].getRectangle().intersects(plane.getRectangle());
			
			if(touch) {
				plane.live = false;
				if(bao == null) {
					bao = new Explode(plane.x, plane.y);
					endTime = new Date();
					period = (int)(endTime.getTime() - startTime.getTime())/1000;
				}
				
				bao.draw(g);
			}
			if(!plane.live) {
				Font font = g.getFont();
				Color color = g.getColor();
				g.setColor(Color.red);
				g.setFont(new Font("宋体", Font.BOLD, 50));
				g.drawString("时间：" + period + "秒", 100, 250);
				g.setFont(font);
				g.setColor(color);
			}
			
		}
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
		this.setSize(Constant.GAME_WIDTH, Constant.GAME_HEIGHT);
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
		
		//初始化50个炮弹
		for(int i=0;i<shells.length;i++) {
			shells[i] = new Shell();
		}
	}
	
	
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
	//双缓冲设置消除闪烁
	private Image offScreenImage = null;
	
	public void update(Graphics g) {
		if(offScreenImage == null) {
			offScreenImage = this.createImage(Constant.GAME_WIDTH, Constant.GAME_HEIGHT);
		}
		Graphics gOff = offScreenImage.getGraphics();
		paint(gOff);
		g.drawImage(offScreenImage, 0, 0, null);
	}
}
