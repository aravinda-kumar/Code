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
 * �ɻ���Ϸ��������
 * @author SHUNCS
 *
 */
public class MyGameFrame extends JFrame{
	
	//���������ͷɻ�����
	Image bg = GameUtil.getImage("images/bg.jpg");
	Image planeImg = GameUtil.getImage("images/plane.png");
	
	//��ʾ�ɻ�
	Plane plane = new Plane(planeImg, 250, 250);
	
	
	//����һ���ڵ�
	//Shell shell = new Shell();
	
	Shell[] shells = new Shell[50];
	
	//�Զ�����
	//����g�൱��һֱ����
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		
		//�ڸ���λ�û��Ƴ�������ǰ��ͼƬ
		g.drawImage(bg, 0, 0, null);
		
		//���Ʒɻ�
		plane.drawSelf(g);
		
		//�����ڵ�
		//shell.draw(g);
		
		//����һ���ڵ�
		for(int i=0;i<shells.length;i++) {
			shells[i].draw(g);
			
			boolean touch = shells[i].getRectangle().intersects(plane.getRectangle());
			
			if(touch) {
				plane.live = false;
			}
		}
	}
	
	//�������Ƿ������ػ�����
	class PaintThread extends Thread{
		//�ڲ������ֱ��ʹ���ⲿ�������
		@Override
		public void run() {
			while(true) {
				//System.out.println("+++++++++++");
				repaint();	//�ػ�����
				
				try {
					Thread.sleep(40);
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		}
	}
	
	//���̼���
	class KeyMonitor extends KeyAdapter{

		//���̰���
		@Override
		public void keyPressed(KeyEvent e) {
			plane.addDirection(e);
		}

		//�����ͷ�
		@Override
		public void keyReleased(KeyEvent e) {
			plane.minusDirection(e);
		}
		
	}
	
	//��ʼ������
	public void launchFrame() {
		//���ô��ڱ���
		this.setTitle("Game");
		//��ʾ����
		this.setVisible(true);
		//���ô��ڵĴ�С
		this.setSize(Constant.GAME_WIDTH, Constant.GAME_HEIGHT);
		//���ô��ڵ�Ĭ��λ��
		this.setLocation(300, 300);
		
		//�رմ���
		this.addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});
		
		new PaintThread().start();
		addKeyListener(new KeyMonitor()); //��������Ӽ���
		System.out.println("�����β");
		
		//��ʼ��50���ڵ�
		for(int i=0;i<shells.length;i++) {
			shells[i] = new Shell();
		}
	}
	
	
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
	//˫��������������˸
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
