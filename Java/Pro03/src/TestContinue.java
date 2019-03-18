
public class TestContinue {
	public static void main(String[] args) {
		int count =0;
		for(int i=0;i<150;i++) {
			if(i%3==0) {
				continue;
			}
			else {
				count++;
				if(count%5==0) {
					System.out.println(i);
				}
				else {
					System.out.print(i+"\t");
				}
			}
		}
	}
}
