package zhushuai.collection;

import java.util.ArrayList;
import java.util.List;

/**
 * ≤‚ ‘∑∫–Õ
 * @author 11094
 *
 */
public class TestGeneric {
	public static void main(String[] args) {
		MyCollection<String> mc = new MyCollection<String>();
		mc.set("zhushuai", 0);
		mc.set(1111, 1);
		//Integer a = Integer.parseInt("123");°§
		String str = mc.get(0);
		System.out.println(str);
		
	}
}

class MyCollection<E>{
	Object[] objs = new Object[5];
	
	public void set(Object obj, int index) {
		objs[index] = obj;
	}
	
	public E get(int index) {
		return (E)objs[index];
	}
}