package zhushuai.testDate;

import java.io.File;

public class PrintDirectory {
	public static void main(String[] args) {
		File file = new File("D:\\DATA");
		printFile(file, 0);
	}
	
	static void printFile(File file, int level) {
		for(int i=0;i<level;i++) {
			System.out.print("-");
		}
		System.out.println(file.getName());
		
		if(file.isDirectory()) {
			//返回当前目录下所有的文件和文件夹的名称；绝对路径
			File[] files = file.listFiles();
			for(File tempFile : files) {
				//System.out.println(tempFile);
				printFile(tempFile, level+1);
			}
		}
	}
}
