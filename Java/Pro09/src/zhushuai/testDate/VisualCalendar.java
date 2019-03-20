package zhushuai.testDate;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Scanner;

/**
 * 可视化日历程序
 * @author SHUNCS
 *
 */
public class VisualCalendar {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("请输入要查询的日期:(格式:2019-3-20)");
		String dateString = scanner.nextLine();
		
		System.out.println("日\t一\t二\t三\t四\t五\t六");
		
		String temp = dateString;
		DateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		try {
			Date date = format.parse(temp);
			Calendar calendar = new GregorianCalendar();
			calendar.setTime(date);
			
			int day = calendar.get(Calendar.DATE);
			
			//将日期转换成一个月的第一天
			calendar.set(Calendar.DATE, 1);
			
			//获取当月第一天所在的星期数
			int firstDay = calendar.get(Calendar.DAY_OF_WEEK);
			//获得一个月的天数
			int spanDay = calendar.getActualMaximum(Calendar.DATE);

			int count = 0;
			for(int i=1;i<firstDay+spanDay;i++) {
				count++;
				if(i < firstDay){
					System.out.print("\t");
				}
				else {
					if(i-firstDay+1 == day) {
						System.out.print(i-firstDay+1+"*\t");
					}
					else {
						System.out.print(i-firstDay+1+"\t");						
					}
				}
				if(count%7==0) {
					
					System.out.println();
				}
				
			}
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		scanner.close();
	}
}
