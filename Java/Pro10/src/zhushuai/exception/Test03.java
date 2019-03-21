package zhushuai.exception;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

/**
 * throws测试throws异常
 * @author 11094
 *
 */
public class Test03 {
	public static void main(String[] args) throws IOException {
			readMyFile();
	}

	public static void readMyFile() throws IOException{
		FileReader reader = null;
		reader = new FileReader("d:/a.txt");		
		char c1 = (char)reader.read();
		System.out.println(c1);
		
		System.out.println("异常处理结束");
		if(reader != null) {
			reader.close();					
		}
	}
}
