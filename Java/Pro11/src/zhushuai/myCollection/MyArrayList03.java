package zhushuai.myCollection;

/**
 * 自定义实现一个arraylisy
 * @author 11094
 * 
 */
public class MyArrayList03<E>{
	
	//元素内容
	private Object[] elementData;
	//元素的个数
	private int size;
	private final static int DEFAULT_CAPACITY = 10;
	
	//构造器
	public MyArrayList03() {
		//elementData = new Object[DEFAULT_CAPACITY];
		this(DEFAULT_CAPACITY);
	}
	
	public MyArrayList03(int capacity) {
		elementData = new Object[capacity];
	}
	
	//add方法
	public void add(E obj) {
		//什么时候扩容
		//怎么扩容
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
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	public static void main(String[] args) {
		MyArrayList03<String> mal = new MyArrayList03<String>(20);
		for(int i=0;i<10;i++) {
			mal.add("zs"+i);
		}
		
		System.out.println(mal);
	}
}
