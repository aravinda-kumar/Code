package zhushuai.testDate;

import java.io.File;

public class TestFile {
	public static void main(String[] args) {
		File file  = new File("E:\\JZS\\Code\\Java\\MyPro01\\src\\BallGame.java");
		File file2 = new File("E:\\JZS\\Code\\Java\\MyPro01\\src");
		File file3 = new File("E:\\JZS\\Code\\Java\\Pro09\\src");
		File file4 = new File(file3, "666.java");
		File file5 = new File("D:/aa/bb/cc");
		file5.mkdirs();
		try {			
			file4.createNewFile();
		} catch (Exception e) {
			// TODO: handle exception
		}
		
		file4.delete();
		
		if(file.isFile()) {
			System.out.println("File");
		}
		if(file2.isDirectory()) {
			System.out.println("Directory");
		}
	}
}
