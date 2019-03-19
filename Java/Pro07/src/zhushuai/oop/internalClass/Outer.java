package zhushuai.oop.internalClass;


public class Outer {
	public static void main(String[] args) {
		Face face = new Face();
		
		Face.Nose nose = face.new Nose();
		nose.breath();
		Face.Ear ear = new Face.Ear();
		ear.hear();
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