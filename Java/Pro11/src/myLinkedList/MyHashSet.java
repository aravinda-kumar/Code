package myLinkedList;

import java.util.HashSet;
import java.util.Set;

/**
 * ����hashSet�Ļ����÷�
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
