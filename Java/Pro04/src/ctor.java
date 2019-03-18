/**
 * ππ‘Ï∆˜≤‚ ‘
 * @author SHUNCS
 *
 */
public class ctor {
	public static void main(String[] args) {
		Point point = new Point(3.0, 4.0);
		Point origin = new Point(0, 0);
		System.out.println(point.getDistance(origin));
		point.showStatic();
	}
}

class Point{
	double x,y;
	public Point(double _x, double _y){
		x = _x;
		y = _y;
	}
	public double getDistance(Point p) {
		return Math.sqrt((x-p.x)*(x-p.x)+(y-p.y)*(y-p.y));
	}
	public static void showStatic() {
		System.out.println("this is a static func");
	}
}