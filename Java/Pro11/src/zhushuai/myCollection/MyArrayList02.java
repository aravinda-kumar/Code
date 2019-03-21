package zhushuai.myCollection;

/**
 * 自定义实现一个arraylisy
 * @author 11094
 *
 */
public class MyArrayList02<E>{
	
	//元素内容
	private Object[] elementData;
	//元素的个数
	private int size;
	private final static int DEFAULT_CAPACITY = 10;
	
	//构造器
	public MyArrayList02() {
		//elementData = new Object[DEFAULT_CAPACITY];
		this(DEFAULT_CAPACITY);
	}
	
	public MyArrayList02(int capacity) {
		elementData = new Object[capacity];
	}
	
	//add方法
	public void add(E obj) {
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
		MyArrayList02<String> mal = new MyArrayList02<String>(20);
		mal.add("aa");
		mal.add("bb");
		mal.add("cc");
		
		System.out.println(mal);
	}
}
