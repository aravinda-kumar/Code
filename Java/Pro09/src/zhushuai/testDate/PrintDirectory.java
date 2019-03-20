package zhushuai.testDate;

import java.io.File;

public class PrintDirectory {
	public static void main(String[] args) {
		File file = new File("E:\\JZS");
		printFile(file, 0);
	}
	
	static void printFile(File file, int level) {
		for(int i=0;i<level;i++) {
			System.out.print("-");
		}
		System.out.println(file.getName());
		
		if(file.isDirectory()) {
			File[] files = file.listFiles();
			for(File tempFile : files) {
				printFile(tempFile, level+1);
			}
		}
	}
}
