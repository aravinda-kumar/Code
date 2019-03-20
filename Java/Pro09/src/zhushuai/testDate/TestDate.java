package zhushuai.testDate;

import java.util.Date;

public class TestDate {
	public static void main(String[] args) {
		Date d = new Date();
		long l = System.currentTimeMillis();
		System.out.println(l);
	    
		Date d2 = new Date(1000);
		System.out.println(d2.toGMTString());
	}
}
