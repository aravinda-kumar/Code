package zhushuai.array;
import java.util.Arrays;

/**
 * ²âÊÔ¶àÎ¬Êı×é
 * @author SHUNCS
 *
 */
public class Matrix {
	public static void main(String[] args) {
		int[][] a = {
						{1,3},
						{2,4}
					};
		int [][]b = {
						{3,4},
						{5,6}
					};
//		int [][] c = new int[2][2];
//		for(int i=0;i<a.length;i++) {
//			for(int j=0;j<a[i].length;j++) {
//				c[i][j] = a[i][j] + b[i][j];
//			}
//		}
//		
//		for(int i=0;i<c.length;i++) {
//			for(int j=0;j<c[i].length;j++) {
//				System.out.print(c[i][j] + " ");
//			}
//			System.out.println();
//		}
//		
//		System.arraycopy(a, 0, b, 0, a.length);
//		b[0][0] = 15;
//		for(int i=0;i<c.length;i++) {
//			for(int j=0;j<c[i].length;j++) {
//				System.out.print(a[i][j] + " ");
//			}
//			System.out.println();
//		}
		System.out.println(Arrays.toString(a[0]));
	}
}
