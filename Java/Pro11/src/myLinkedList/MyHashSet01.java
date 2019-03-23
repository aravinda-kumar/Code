package myLinkedList;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Set;

/**
 * 测试hashSet的基本用法
 * @author zhushuai
 *
 */
public class MyHashSet01 {
	HashMap<String,Object> map;
	
	private static final Object PRESENT = new Object();
	
	public MyHashSet01() {
		map = new HashMap<String,Object>();
	}
	
	public void add(String str) {
		map.put(str, PRESENT);
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append('[');
		for(String itemString : map.keySet()) {
			sb.append(itemString + " ");
		}
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	public static void main(String[] args) {
		MyHashSet01 hash = new MyHashSet01();
		hash.add("aaa");
		hash.add("bbb");
		hash.add("bbb");
		hash.add("ddd");
		
		System.out.println(hash);
	}
}
