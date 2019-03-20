package zhushuai.testDate;

import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class TestCalender {
	public static void main(String[] args) {
		Calendar c = new GregorianCalendar();
//		c.set(2001, 1, 10, 12, 23, 34);
		c.set(Calendar.YEAR, 2001);
		c.set(Calendar.MONTH, Calendar.MARCH);
		c.set(Calendar.DATE, 10);
		c.add(Calendar.YEAR, -20);
		Date d = c.getTime();
		System.out.println(d);
	}
}
