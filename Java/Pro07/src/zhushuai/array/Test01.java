package zhushuai.array;

/**
 * ²âÊÔ¶àÎ¬Êı×é
 * @author SHUNCS
 *
 */
public class Test01 {
	public static void main(String[] args) {
		int[][] a = {{1,2},{3,4,5,6},{7,8,9}};
		for(int[] arr : a) {
			for(int item : arr) {
				System.out.print(item + " ");
			}
			System.out.println();
		}
		
		int[][] a01 = new int[3][];
		a01[0] = new int[2];
		a01[1] = new int[4];
		a01[2] = new int[3];
		
	}
}
