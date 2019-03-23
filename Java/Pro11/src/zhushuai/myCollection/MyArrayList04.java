package zhushuai.myCollection;

import javax.management.RuntimeErrorException;

/**
 * 自定义实现一个arraylisy
 * 增加set和get方法，以及边界检查
 * 增加remove方法
 * @author 11094
 * 
 */
public class MyArrayList04<E>{
	
	//元素内容
	private Object[] elementData;
	//元素的个数
	private int size;
	private final static int DEFAULT_CAPACITY = 10;
	
	//构造器
	public MyArrayList04() {
		//elementData = new Object[DEFAULT_CAPACITY];
		this(DEFAULT_CAPACITY);
	}
	
	public MyArrayList04(int capacity) {
		if(capacity < 0) {
			throw new RuntimeException("容量不合法");
		}else if (capacity == 0) {
			elementData = new Object[DEFAULT_CAPACITY];
		}else {
			elementData = new Object[capacity];			
		}
	}
	
	//add方法
	public void add(E obj) {
		//什么时候扩容
		if (size == elementData.length - 1) {
			//加号的优先级高于以为运算符
			Object[] newArray = new Object[elementData.length + (elementData.length >> 1)];	 //新数组是原来数组长度的1.5倍
			System.arraycopy(elementData, 0, newArray, 0, elementData.length);
			
			//指向新的数组的地址，实现扩容
			elementData = newArray;
		}
		//继续添加元素
		elementData[size++] = obj;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append("[");
		for(int i=0;i<size;i++) {
			sb.append(elementData[i] + " ");
		}
		//将结尾得空格替换为右括号
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	public E get(int index) {
		checkRange(index);
		return (E)elementData[index];
	}
	
	public void set(int index, E element) {
		//边界检查
		checkRange(index);
		elementData[index] = element;
	}
	
	private void checkRange(int index) {
		if(index <0 || index >= size) {
			//索引越界
			throw new IndexOutOfBoundsException("索引越界:" + index);
		}
	}
	
	public void remove(E element) {
		//element和所有元素挨个比较，获得第一个比较为true的返回
		for(int i=0;i<size;i++) {
			if(element.equals(elementData[i])) {
				//将该元素从此处移除
				remove(i);
				break; //break控制只删除第一个
			}
		}
	}
	
	public void remove(int index) {
		checkRange(index);
		// 循环拷贝
		int numMoved = size-index-1;
		if(numMoved>0) {
			System.arraycopy(elementData, index+1, elementData, index, numMoved);			
		}
		//最有一个用来补位的元素是null;
		set(size-1, null);
		size--;
	}
	
	public int size() {
		return size;
	}
	
	public boolean isEmpty() {
		return size == 0;
	}
	
	public static void main(String[] args) {
		MyArrayList04<String> mal = new MyArrayList04<String>(20);
		for(int i=0;i<40;i++) {
			mal.add("zs"+i);
		}
		
		System.out.println(mal);
		
		System.out.println(mal.get(39));
		
		mal.set(39, "zhushuai");
		System.out.println(mal);
		
		mal.remove(3);
		System.out.println(mal);
		mal.remove("zhushuai");
		System.out.println(mal);
		System.out.println(mal.size());
		System.out.println(mal.isEmpty());
	}
}
