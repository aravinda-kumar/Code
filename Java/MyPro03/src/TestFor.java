
/**
 * 测试for循环
 * @author 高淇
 *
 */
public class TestFor {
	public static void main(String[] args) {
		int  sum = 0;
		
		for(int  i=1; i<=100;i++){
			sum  = sum + i;
		}
	
		System.out.println(sum);
		
		/*
			int   i = 1;
			while(i<=100){
				 sum  =  sum  + i;
				i++;
			}
		*/
		
		/**
		 * 1. 执行初始化语句： i=1;
		 * 2. 判断i<=100
		 * 3. 执行循环体
		 * 4. 步进迭代：i++
		 * 5. 回到第二步继续判断
		 */
		
		 for(int i = 1, j = i + 10; i < 5; i++, j = i * 2) {
	            System.out.println("i= " + i + " j= " + j); 
	     } 
		 
		 for(;;){	//while(true){
			 System.out.println("爱你到永远！！");
		 }
		 
	}
}
