
/**
 * test break
 * @author SHUNCS
 *
 */
public class TestBreak {
	public static void main(String[] args) {
		int total = 0;
		System.out.println("开始循环......");
		int num = 0;
		while(true) {
			total++;
			num = (int)(100*Math.random());
			//System.err.println(num);
			if(num == 88) {
				break;
			}
		}
		System.out.println("共计循环了"+total+"次");
	}
}
