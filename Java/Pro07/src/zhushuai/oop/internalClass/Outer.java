package zhushuai.oop.internalClass;


public class Outer {
	public static void main(String[] args) {
		Face face = new Face();
		
		Face.Nose nose = face.new Nose();
		nose.breath();
		Face.Ear ear = new Face.Ear();
		ear.hear();
		
		System.out.println("=========================");
		
		Circle circle = new Circle(1.2);
		Circle.Draw draw = circle.new Draw();
		draw.drawSahpe();
		
		circle.showDraw();
		
		Outer outer = new Outer();
		Outer.Base01 base = outer.new Base01();
		
		System.out.println("=========================");
		Anno anno = new Anno();
		anno.disclose();
	}
	public void test(){
		Base01 base01 = new Base01();
	}
	class Base01{
		int a;
	}
}

class Face{
	int type;
	static int a = 12;
	class Nose{
		String type;
		
		void breath() {
			System.out.println(Face.this.type);
		}
	}
	
	static class Ear{
		public void hear(){
			System.out.println("listen");
			System.out.println(a);
		}
	}
}

class Circle {
	private double radius = 0;
	public static int count =1;
     
    public Circle(double radius) {
        this.radius = radius;
    }
    
    public void showDraw() {
    	Draw draw = new Draw();
    	draw.drawSahpe();
    	//必须通过内部类的实例调用
    	//error drawSahpe();
    }
    
    class Draw {     //内部类
        public void drawSahpe() {
            System.out.println("drawshape");
            System.out.println(radius);  //外部类的private成员
            System.out.println(count);   //外部类的静态成员
        }
    }
}

interface inner{
	void display();
}

class Anno{
	public void disclose() {
		new inner() {
			@Override
			public void display() {
				System.out.println("This is a anno");
				
			}
		}.display();
	}
}