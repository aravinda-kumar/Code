package zhushuai.game;

import java.awt.Color;
import java.awt.Graphics;

public class Shell extends GameObject{
	double degree;
	
	public Shell() {
		x = 200;
		y = 200;
		width = 10;
		height = 10;
		speed = 4;
		
		//�Ƕ���һ�������
		degree = Math.random()*2*Math.PI;
	}
	
	public void draw(Graphics g) {
		Color color = g.getColor();
		g.setColor(Color.YELLOW);
		g.fillOval((int)x, (int)y, width, height);
		
		//�Ƕ���һ�������
		//degree = Math.random()*2*Math.PI;
		
		//�ڵ���������Ƕȷ���
		x += speed*Math.cos(degree);
		y += speed*Math.sin(degree);
		if(x <= 0 || x+width >= Constant.GAME_WIDTH) {
			degree = Math.PI - degree;
		}
		
		if(y-30 <= 0 || y+height >= Constant.GAME_HEIGHT) {
			degree = - degree;
		}
		
		g.setColor(color);
	}
}
