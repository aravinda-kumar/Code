package myLinkedList;

import java.util.HashSet;
import java.util.Set;

/**
 * 测试hashSet的基本用法
 * @author zhushuai
 *
 */
public class MyHashSet {
	public static void main(String[] args) {
		Set<String> set = new HashSet<String>();
		set.add("bbb");
		set.add("ccc");
		set.add("aaa");
		set.add("aaa");
		
		System.out.println(set);
	}
}
