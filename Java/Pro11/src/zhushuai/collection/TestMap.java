package zhushuai.collection;

import java.util.HashMap;
import java.util.Map;

/**
 * ≤‚ ‘map
 * @author zhushuai
 *
 */
public class TestMap {
	public static void main(String[] args) {
		Map<Integer, String> m1 = new HashMap<Integer, String>();
		
		m1.put(1, "one");
		m1.put(2, "two");
		m1.put(3, "three");
		
		System.out.println(m1.get(1));
		System.out.println(m1.size());
		System.out.println(m1.isEmpty());
		System.out.println(m1);
	}
}
