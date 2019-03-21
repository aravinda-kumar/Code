package zhushuai.collection;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

/**
 * 测试collection接口中的方法
 * @author 11094
 *
 */
public class TestList {
	public static void main(String[] args) {
		test03();
	}
	
	public static void test01() {
		ArrayList<String> c = new ArrayList<String>();
		
		System.out.println(c.size());
		System.out.println(c.isEmpty());
		
		System.out.println("===============================");
		
		c.add("zhushuai");
		c.add("johnson");
		System.out.println(c);
		Object[] strs = c.toArray();
		c.remove("zhushuai");
		System.out.println(c);
		System.out.println(c.contains("zhushuai"));
		c.clear();
		System.out.println(c);
		
		for(Object item : strs) {
			System.out.println((String)item);
		}
		
		System.out.println("===============================");
		Collection<String> co = new ArrayList<String>();
		co.add("aaa");
		co.add("bbb");
		co.add("ccc");
		co.add("ddd");
		String[] strings = new String[1];
		strings = co.toArray(strings);
		for(String item : strings) {
			System.out.println(item);
		}
	}
	
	public static void test02() {
		List<String> list01 = new ArrayList<String>();
		list01.add("aa");
		list01.add("bb");
		list01.add("cc");
		
		List<String> list02 = new ArrayList<String>();
		list02.add("aa");
		list02.add("dd");
		list02.add("ee");
		
		System.out.println(list01);
		System.out.println(list02);
		
		list01.addAll(list02);
//		list01.removeAll(list02);
		list01.retainAll(list02);
		System.out.println(list01);
		
		System.out.println(list01.containsAll(list02));
		
	}

	public static void test03() {
		List<String> list = new ArrayList<String>();
		list.add("A");
		list.add("B");
		list.add("C");
		list.add("D");
		
		System.out.println(list);
		
		list.add(2, "wo");
		System.out.println(list);
		
		list.remove(2);
		System.out.println(list);
		
		list.set(2, "JZS");
		System.out.println(list);
		
		System.out.println(list.get(2));
	}
}


