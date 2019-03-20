package zhushuai.testDate;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class TestDateFormate {
	public static void main(String[] args) {
		DateFormat df = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss:SSS");
		Date d = new Date(123456456123113L);
		String str = df.format(d);
		System.out.println(str);
		
		String str01 = "1977-7-7";
		//格式必须和字符串完全一致
		DateFormat df01 = new SimpleDateFormat("yyyy-MM-dd");
		try {
			Date d2 = df01.parse(str01);
			System.out.println(d2);
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
	}
}
