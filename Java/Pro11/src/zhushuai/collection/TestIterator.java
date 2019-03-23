package zhushuai.collection;

import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;

/**
 * 测试迭代器
 * @author zhushuai
 *
 */
public class TestIterator {
	public static void main(String[] args) {
		testIteratorMap();
	}
	
	public static void testIteratorMap() {
		Map<Integer, String> map = new HashMap<Integer, String>();
		map.put(1, "one");
		map.put(2, "two");
		map.put(3, "three");
		map.put(4, "four");
		map.put(5, "five");
		
		//方法一
		Set<Entry<Integer, String>> mapset = map.entrySet();
		for(Iterator<Entry<Integer, String>> iter = mapset.iterator();iter.hasNext();) {
			Entry<Integer, String> entry = iter.next();
			System.out.println(entry.getKey() + "===" + entry.getValue());
		}
		
		System.out.println("==================");
		
		//方法二
		Set<Integer> mapSet2 = map.keySet();
		for(Iterator<Integer> iter = mapSet2.iterator(); iter.hasNext();) {
			Integer item = iter.next();
			System.out.println(item + "===" + map.get(item));
		}
	}
	
	public static void testIteratorList() {
		List<String> list = new ArrayList<String>();
		list.add("aa");
		list.add("bb");
		list.add("cc");
		list.add("dd");
		//Iterator<String> iter = list.iterator();
		for(Iterator<String> iter = list.iterator();iter.hasNext();) {
			String temp = iter.next();
			System.out.println(temp);
		}
	}
	
	public static void testIteratorSet() {
		Set<String> list = new HashSet<String>();
		list.add("aa");
		list.add("bb");
		list.add("cc");
		list.add("dd");
		//Iterator<String> iter = list.iterator();
		for(Iterator<String> iter = list.iterator();iter.hasNext();) {
			String temp = iter.next();
			System.out.println(temp);
		}
	}
}
