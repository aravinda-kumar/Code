package zhushuai.game;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
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
	Image plane = GameUtil.getImage("images/plane.png");
	
	//�ɻ�����
	int planeX = 250;
	int planeY = 250;
	
	//�Զ�����
	//����g�൱��һֱ����
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		
		//�ڸ���λ�û��Ƴ�������ǰ��ͼƬ
		g.drawImage(bg, 0, 0, null);
		g.drawImage(plane, planeX, planeY, null);
		planeX++;
		planeY++;
	}
	
	//�������Ƿ������ػ�����
	class PaintThread extends Thread{
		//�ڲ������ֱ��ʹ���ⲿ�������
		@Override
		public void run() {
			while(true) {
				System.out.println("+++++++++++");
				repaint();	//�ػ�����
				
				try {
					Thread.sleep(40);
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		}
	}
	
	//��ʼ������
	public void launchFrame() {
		//���ô��ڱ���
		this.setTitle("Game");
		//��ʾ����
		this.setVisible(true);
		//���ô��ڵĴ�С
		this.setSize(500, 500);
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
	}
	
	
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
}
