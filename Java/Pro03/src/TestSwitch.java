
/**
   *    测试switch结构
 * @author SHUNCS
 *
 */
public class TestSwitch {
	public static void main(String[] args) {
		int month = (int)(1 + Math.random()*12);
		System.out.println("月份:"+month);
		switch (month) {
		case 1:
			System.out.println("一月份");
			break;
		case 2:
			System.out.println("二月份");
		default:
			System.out.println("其他月份");
			break;
		}
		System.out.println("#####################");
		//元音判断
		char ch = 'a';
		ch = (char)(ch + (int)(26*Math.random()));
		System.out.println("ch = "+ ch);
		switch(ch) {
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			System.out.println("元音字母");
			break;
		case 'y':
		case 'w':
			System.out.println("半元音");
			break;
		default:
			System.out.println("辅音");
		}
	}
}
