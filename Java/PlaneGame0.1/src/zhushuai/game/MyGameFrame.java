package zhushuai.game;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.swing.JFrame;

/**
 * 飞机游戏的主窗口
 * @author SHUNCS
 *
 */
public class MyGameFrame extends JFrame{
	
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
	}
	
	public static void main(String[] args) {
		MyGameFrame f = new MyGameFrame();
		f.launchFrame();
	}
	
}
