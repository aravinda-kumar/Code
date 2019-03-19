package zhushuai.game;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.Rectangle;

/**
 * base for the game
 * @author SHUNCS
 *
 */
public class GameObject {
	Image img;
	double x, y;
	int speed;
	int width, height;
	
	public void drawSelf(Graphics g) {
		g.drawImage(img, (int)x, (int)y, null);
	}

	public GameObject(Image img, double x, double y) {
		super();
		this.img = img;
		this.x = x;
		this.y = y;
	}

	public GameObject() {
		super();
	}

	//返回物体所在的矩形，便于后续的碰撞检测
	public Rectangle getRectangle() {
		return new Rectangle((int)x, (int)y, width, height);
	}
	
	
}
