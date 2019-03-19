package zhushuai.game;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.swing.JFrame;

/**
 * �ɻ���Ϸ��������
 * @author SHUNCS
 *
 */
public class MyGameFrame extends JFrame{
	
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
	}
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
}
