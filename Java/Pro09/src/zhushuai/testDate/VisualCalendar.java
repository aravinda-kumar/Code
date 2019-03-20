package zhushuai.testDate;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Scanner;

/**
 * ���ӻ���������
 * @author SHUNCS
 *
 */
public class VisualCalendar {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("������Ҫ��ѯ������:(��ʽ:2019-3-20)");
		String dateString = scanner.nextLine();
		
		System.out.println("��\tһ\t��\t��\t��\t��\t��");
		
		String temp = dateString;
		DateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		try {
			Date date = format.parse(temp);
			Calendar calendar = new GregorianCalendar();
			calendar.setTime(date);
			
			int day = calendar.get(Calendar.DATE);
			
			//������ת����һ���µĵ�һ��
			calendar.set(Calendar.DATE, 1);
			
			//��ȡ���µ�һ�����ڵ�������
			int firstDay = calendar.get(Calendar.DAY_OF_WEEK);
			//���һ���µ�����
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
