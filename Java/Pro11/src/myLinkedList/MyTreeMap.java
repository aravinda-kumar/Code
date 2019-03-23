package myLinkedList;

import java.util.Map;
import java.util.TreeMap;

/**
 * treemap的使用
 * @author zhushuai
 *
 */
public class MyTreeMap {
	public static void main(String[] args) {
		Map<Integer, String> map = new TreeMap<Integer, String>();
		
		map.put(20, "aa");
		map.put(6, "bb");
		map.put(6, "cc");
		
		for(Integer m:map.keySet()) {
			//按照Key递增的方式排序
			System.out.println(m + "---" + map.get(m));
		}
		
		System.out.println("===================");
		
		Map<Emp, String> map2 = new TreeMap<Emp, String>();
		Emp emp1 = new Emp(1001, "aaa", 7000);
		Emp emp2 = new Emp(1002, "bbb", 10000);
		Emp emp3 = new Emp(1003, "ccc", 8000);
		Emp emp4 = new Emp(1004, "ddd", 7000);
		Emp emp5 = new Emp(1005, "eee", 3000);
		
		map2.put(emp1, "aaa");
		map2.put(emp2, "bbb");
		map2.put(emp3, "ccc");
		System.out.println(map2.put(emp4, "ddd"));;
		System.out.println(map2.put(emp5, "eee"));;
		
//		System.out.println(map2.get(emp1));
//		System.out.println(map2.get(emp4));
		
		for(Emp tmp : map2.keySet()) {
			System.out.println(tmp + "====" + map2.get(tmp));
		}
	}
}

class Emp implements Comparable<Emp>{
	int id;
	String name;
	double salary;
	public Emp(int id, String name, double salary) {
		super();
		this.id = id;
		this.name = name;
		this.salary = salary;
	}
	@Override
	public int compareTo(Emp o) {
		if(salary > o.salary) {
			return 1;
		}
		else if (salary < o.salary) {
			return -1;
		}else {
//			if(id > o.id) {
//				return 1;
//			}else if(id < o.id) {
//				return -1;
//			}else {
				return 0;
//			}
		}
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return id + ";" + name + ";" + salary;
	}
}
