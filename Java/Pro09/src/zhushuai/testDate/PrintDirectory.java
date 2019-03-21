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
			//���ص�ǰĿ¼�����е��ļ����ļ��е����ƣ�����·��
			File[] files = file.listFiles();
			for(File tempFile : files) {
				//System.out.println(tempFile);
				printFile(tempFile, level+1);
			}
		}
	}
}
