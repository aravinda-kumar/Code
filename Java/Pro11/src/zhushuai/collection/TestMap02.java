package zhushuai.collection;

import java.util.HashMap;
import java.util.Map;

/**
 * ≤‚ ‘map
 * @author zhushuai
 *
 */

public class TestMap02 {
	public static void main(String[] args) {
		Employee e1 = new Employee(1001, "aaa", 50000);
		Employee e2 = new Employee(1002, "bbb", 6000);
		Employee e3 = new Employee(1003, "ccc", 5000);
		
		Map<Integer, Employee> map = new HashMap<Integer, Employee>();
		
		map.put(1001, e1);
		map.put(1002, e2);
		map.put(1003, e3);
		
		Employee emp = map.get(1001);
		System.out.println(emp.getName());
		System.out.println(map);
	}
}

//πÕ‘±–≈œ¢
class Employee{
	private int id;
	private String name;
	private double salary;
	public Employee(int id, String name, double salary) {
		super();
		this.id = id;
		this.name = name;
		this.salary = salary;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public double getSalary() {
		return salary;
	}
	public void setSalary(double salary) {
		this.salary = salary;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return id + " " + name + " " + salary;
	}
}