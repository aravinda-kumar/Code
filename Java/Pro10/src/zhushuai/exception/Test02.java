package zhushuai.exception;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Test02 {
	public static void main(String[] args) {
			readMyFile();
		}

	public static void readMyFile() {
		FileReader reader = null;
		try {
			reader = new FileReader("d:/a.txt");		
			char c1 = (char)reader.read();
			System.out.println(c1);
			
		}catch(FileNotFoundException e) {	//�����쳣�ڸ����쳣ǰ��
				
		}catch(IOException e) {
				
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			System.out.println("�쳣�������");
			try {
				if(reader != null) {
					reader.close();					
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
}
