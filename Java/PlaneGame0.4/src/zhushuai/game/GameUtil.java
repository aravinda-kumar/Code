package zhushuai.game;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.net.URL;

import javax.imageio.ImageIO;


public class GameUtil {
	private GameUtil() {
		
	}
	
	/**
	 * ����ָ��·���ļ���ָ������
	 * @param path
	 * @return
	 */
	public static Image getImage(String path) {
		BufferedImage bi = null;
		try {
			URL u = GameUtil.class.getClassLoader().getResource(path);
			bi = ImageIO.read(u);
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		return bi;
	}
}
