
/**
 * 测试ifelse双选择结构
 * @author 高淇
 *
 */
public class TestIfElse {
	public static void main(String[] args) {
		int  h= (int)(6*Math.random()+1);
		System.out.println(h);
		if(h<=3) {
			 System.out.println("小");
		}else{
			System.out.println("大");
		}
		
		System.out.println("####################");
		//随机产生一个[0.0, 4.0)区间的半径，并根据半径求圆的面积和周长
        double r = 4 * Math.random();
       //Math.pow(r, 2)求半径r的平方
        double area = Math.PI* Math.pow(r, 2);
        double circle = 2 * Math.PI * r;
        System.out.println("半径为： " + r);
        System.out.println("面积为： " + area);
        System.out.println("周长为： " + circle);
        //如果面积>=周长，则输出"面积大于等于周长"，否则，输出周长大于面积
        if(area >= circle) {
            System.out.println("面积大于等于周长");
        } else {
            System.out.println("周长大于面积");
        }
		
		
	}
}
