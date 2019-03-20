package zhushuai.stringbuilder;

import javax.net.ssl.SNIHostName;

public class Test02 {

	public static void main(String[] args) {
		StringBuilder sb = new StringBuilder("abcdefghijklmnopqrstuvwxyz");
		//×ó±ÕÓÒ¿ª
		sb.delete(3, 5);
		System.out.println(sb);
		sb.reverse();
		System.out.println(sb);
		
		
		StringBuffer sb2 = new StringBuffer("abcdefghijklmnopqrstuvwxyz");
	}
}
